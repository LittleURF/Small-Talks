using SmallTalks.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmallTalks.Enums;

namespace SmallTalks.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                                            UserManager<ApplicationUser> userManager,
                                            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            // I know its terrible, its just for testing in an app thats not gonna ever get used in the real world by lots of users
            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync("Admin") == null)
            {
                await roleManager.CreateAsync(new ApplicationRole("Admin", "Has control of moderators and can do everything they can"));
            }

            if (await roleManager.FindByNameAsync("Moderator") == null)
            {
                await roleManager.CreateAsync(new ApplicationRole("Moderator", "takes care of editing or deleting offensive or in some other way wrong posts." +
                    " Review reported posts and comments and can ban users."));
            }

            if (await roleManager.FindByNameAsync("Member") == null)
            {
                await roleManager.CreateAsync(new ApplicationRole("Member", "This is the default user role"));
            }



            if (await userManager.FindByEmailAsync("hubertzachlowski@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "LittleURF",
                    Email = "hubertzachlowski@gmail.com",
                    BirthDate = new DateTime(1998, 07, 25),
                    Sex = Sex.Male,
                    Points = 999999
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, "Admin");
                    await userManager.AddToRoleAsync(user, "Moderator");
                }
            }

            if (await userManager.FindByEmailAsync("hubertzachlo@o2.pl") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "TheFrogGirl",
                    Email = "hubertzachlo@o2.pl",
                    BirthDate = new DateTime(2005, 11, 04),
                    Sex = Sex.Female,
                    Points = 200
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, "Member");
                }
            }
        }
    }
}
