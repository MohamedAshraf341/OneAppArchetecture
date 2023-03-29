﻿using BackEnd.Const;
using BackEnd.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace BackEnd.Data.SeedData
{
    public static class DefaultUsers
    {
        public static async Task SeedUserAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "user",
                Email = "user@corelia.ai",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null)
            {
                await userManager.CreateAsync(defaultUser, "UserProject@2023!");
                await userManager.AddToRoleAsync(defaultUser, Roles.User.ToString());
            }
        }
        public static async Task SeedAdminAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@corelia.ai",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null)
            {
                await userManager.CreateAsync(defaultUser, "AdminProject@2023!");
                await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
            }
        }

    }

}
