using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmallTalks.Data;
using SmallTalks.Models;

namespace SmallTalks.Controllers
{
    public class ModeratorController : Controller
    {

        private ApplicationDbContext _dbContext;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;

        [TempData]
        public string TempMessage { get; set; }

        public ModeratorController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BanUser(string userName, string description, DateTime endTime)
        {

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

            // Changing user fields is handled in a MSSQL trigger(Bans table)
            await _dbContext.Bans.AddAsync(ban);
            await _dbContext.SaveChangesAsync();

            TempMessage = $"User { bannedUser.UserName} banned successfully";

            return RedirectToAction(nameof(Index));
        }

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

        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        private async Task<bool> IsBannedAsync(ApplicationUser user)
        {
            if (user.AccountLocked)
            {
                var ban = await _dbContext.Users.Include(u => u.CurrentBan).Where(u => u.CurrentBanId == user.CurrentBanId).Select(u => u.CurrentBan).SingleOrDefaultAsync();

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