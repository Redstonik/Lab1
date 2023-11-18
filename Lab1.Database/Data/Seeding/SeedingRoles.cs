using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Contracts.Data.Entities;
using Lab1.Contracts.Roles;
using Microsoft.AspNetCore.Identity;

namespace Lab1.Database.Data.Seeding
{
    public static class SeedingRoles
    {
        public static async Task SystemRoles(UserManager<User> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(AuthorizationRoles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(AuthorizationRoles.Buyer.ToString()));
            await roleManager.CreateAsync(new IdentityRole(AuthorizationRoles.Seller.ToString()));
            var admin = new User
            {
                Name = "Admin",
                Surname = "Admin",
                UserName = "Admin",
                Email = "admin@admin.com",
                Birthday = DateTime.Now,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != admin.Id))
            {
                await userManager.CreateAsync(admin, "Admin1!");
                await userManager.AddToRoleAsync(admin, AuthorizationRoles.Admin.ToString());
            }
        }
    }
}
