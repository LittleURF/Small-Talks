using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmallTalks.Data;
using SmallTalks.Models;

namespace SmallTalks.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _dbContext;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;

        [TempData]
        public string TempMessage { get; set; }

        public AdminController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var moderatorRoleId = _roleManager.FindByNameAsync("Moderator").Result.Id;

            var moderators = _dbContext.GetUsersWithRole(moderatorRoleId);

            return View(moderators);
        }

        public async Task<IActionResult> AddModerator(string userName)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(userName);
                if (user == null)
                {
                    //show error message
                    return RedirectToAction(nameof(Index));
                }

                await _userManager.AddToRoleAsync(user, "Moderator");

            }

            TempMessage = "Moderator added successfuly!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RemoveModerator(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                //error message
                return RedirectToAction(nameof(Index));
            }

            await _userManager.RemoveFromRoleAsync(user, "Moderator");

            TempMessage = "Moderator removed successfuly!";

            return RedirectToAction(nameof(Index));
        }



    }
}