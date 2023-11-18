﻿using Lab1.Contracts.Data.Entities;
using Lab1.Contracts.Roles;
using Microsoft.AspNetCore.Identity;

namespace Lab1.Services.Validators
{
    public static class Validator
    {
        public static async Task<bool> IsUserEmailUnique(UserManager<User> manager, string email)
        {
            return await manager.FindByEmailAsync(email) == null;
        }
        public static async Task<bool> IsUniqueUserName(UserManager<User> manager, string username)
        {
            return await manager.FindByNameAsync(username) != null;
        }
        public static async Task<bool> IsSystemRoleAndNoAdmin(RoleManager<IdentityRole> manager, AuthorizationRoles role)
        {
            return role == AuthorizationRoles.Admin ||
            await manager.FindByNameAsync(Enum.GetName(role)) == null;
        }
    }
}