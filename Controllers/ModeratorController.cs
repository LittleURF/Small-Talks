using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
            // Check if user is already banned
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

            await _dbContext.Bans.AddAsync(ban);
            await _dbContext.SaveChangesAsync();

            TempMessage = "User Banned successfully";
            // Changing user fields is handled in a MSSQL trigger(Bans table)

            return RedirectToAction(nameof(Index));
        }

        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
    }
}