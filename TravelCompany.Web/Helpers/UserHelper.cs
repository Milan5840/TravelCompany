using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;
using TravelCompany.Web.Models;

namespace TravelCompany.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserHelper(
            UserManager<UserEntity> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> AddUserAsync(UserEntity user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task CheckRoleAsync(string Role)
        {
            bool roleExists = await _roleManager.RoleExistsAsync(Role);

            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = Role
                });
            }

        }

        public async Task<UserEntity> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public Task GetUserByEmailAsync(object email)
        {
            throw new NotImplementedException();
        }

        public Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

    }
}
