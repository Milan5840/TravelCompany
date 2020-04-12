using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserHelper(
            RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task CheckRoleAsync(string roleName)
        {
            bool roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }

        }
    }
}
