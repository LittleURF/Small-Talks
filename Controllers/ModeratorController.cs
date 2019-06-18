using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmallTalks.Data;
using SmallTalks.Enums;
using SmallTalks.Models;
using SmallTalks.ViewModels;

namespace SmallTalks.Controllers
{
    public class ModeratorController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        [TempData]
        public string TempMessage { get; set; }

        public ModeratorController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var reports = await _dbContext.Reports.Include(r => r.Reporter).ToListAsync();
            return View(reports);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BanUser(string userName, string description, DateTime endTime, int? reportId)
        {
            if (endTime < DateTime.Today)
            {
                TempMessage = "Action failed. Ending date of the ban cannot be earlier than today";
                return RedirectToAction(nameof(Index));
            }

            var currentUser = await GetCurrentUserAsync();
            var bannedUser = await _userManager.FindByNameAsync(userName);

            if (bannedUser == null)
            {
                TempMessage = "User not found";
                return RedirectToAction(nameof(Index));
            }

            var ban = new Ban
            {
                UserId = bannedUser.Id,
                BannedById = currentUser.Id,
                Description = description,
                StartTime = DateTime.Now,
                EndTime = endTime,
            };

            if (reportId != null)
            {
                var report = await _dbContext.Reports.Where(r => r.Id == reportId).SingleOrDefaultAsync();
                _dbContext.Reports.Remove(report);
            }

            // Changing user fields is handled in a MSSQL trigger(Bans table)
            await _dbContext.Bans.AddAsync(ban);
            await _dbContext.SaveChangesAsync();

            TempMessage = $"User { bannedUser.UserName} banned successfully";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UnbanUser(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                TempMessage = "User not found";
                return RedirectToAction(nameof(Index));
            }

            var isUserBanned = await IsBannedAsync(user);
            if (!isUserBanned)
            {
                TempMessage = $"User {user.UserName} is not banned";
                return RedirectToAction(nameof(Index));
            }

            await SetToUnbannedAsync(user);

            TempMessage = $"User {user.UserName} unbanned sucessfully!";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetUserBanHistory(string userName)
        {
            var user = await  _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                TempMessage = "User not found";
                return RedirectToAction(nameof(Index));
            }

            var banHistory = await _dbContext.Bans
                .Include(b => b.BannedBy)
                .Include(b => b.User)
                .Where(b => b.UserId == user.Id)
                .OrderByDescending(b => b.StartTime)
                .ToListAsync();

            return View(banHistory);
        }

        public async Task<IActionResult> ReportDetails(int id)
        {
            var model = new ReportDetailsViewModel();
            var report = await _dbContext.Reports.Include(r => r.Reporter).Where(r => r.Id == id).SingleOrDefaultAsync();
            int? postId = null;

            // How the hell do i achieve polymorphism since i shouldnt create methods in Models
            if (report.ReportedObjectType == ObjectType.Post)
            {
                 model.ReportedObject = await _dbContext.Posts.Include(c => c.Creator).Where(p => p.Id == report.ReportedObjectId).SingleOrDefaultAsync();
                postId = model.ReportedObject.Id;
            }

            else if (report.ReportedObjectType == ObjectType.Comment)
            {
                model.ReportedObject = await _dbContext.Comments.Include(c => c.Creator).Where(p => p.Id == report.ReportedObjectId).SingleOrDefaultAsync();
                postId = model.ReportedObject.PostId;

            }

            else if (report.ReportedObjectType == ObjectType.ChildComment)
            {
                model.ReportedObject = await _dbContext.ChildComments.Include(c => c.Creator).Where(p => p.Id == report.ReportedObjectId).SingleOrDefaultAsync();
                postId = model.ReportedObject.PostId;
            }

            model.Report = report;


            model.Post = await _dbContext.Posts
                .Include(p => p.Creator)
                .Include(p => p.PostTags)
                .Include(p => p.Comments).ThenInclude(c => c.Creator)
                .Include(p => p.Comments).ThenInclude(c => c.Comments)
                .Where(p => p.Id == postId)
                .SingleOrDefaultAsync();

            // Load users that are authors of Child Comments
            await _dbContext.Users
                .Where(u => model.Post.Comments
                .Any(c => c.Comments.Any(cc => cc.CreatorId == u.Id)))
                .LoadAsync();


            await _dbContext.Tags.LoadAsync(); // Fills up Tags in the Posts

            return View(model);
        }

        public async Task<IActionResult> RemoveReport(int id)
        {
            var report = await _dbContext.Reports.Where(r => r.Id == id).SingleOrDefaultAsync();

            _dbContext.Reports.Remove(report);
            await _dbContext.SaveChangesAsync();

            TempMessage = "Report ignored";

            return RedirectToAction(nameof(Index));
        }


        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        // to test
        private async Task<bool> IsBannedAsync(ApplicationUser user)
        {
            if (user.AccountLocked)
            {
                var ban = await _dbContext.Users
                    .Include(u => u.Bans)
                    .Where(u => u.CurrentBanId == user.CurrentBanId)
                    .Select(u => u.Bans.Where(b => b.Id == u.CurrentBanId).SingleOrDefault())
                    .SingleOrDefaultAsync();

                if (DateTime.Now > ban.EndTime)
                {
                    await SetToUnbannedAsync(user);
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        private async Task<ApplicationUser> SetToUnbannedAsync(ApplicationUser user)
        {
            user.AccountLocked = false;
            user.CurrentBanId = null;

            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
    }
}