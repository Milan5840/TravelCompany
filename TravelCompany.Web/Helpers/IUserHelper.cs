using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;
using TravelCompany.Web.Models;

namespace TravelCompany.Web.Helpers
{
    public interface IUserHelper
    {

        Task<IdentityResult> AddUserAsync(UserEntity user, string password);
        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task CheckRoleAsync(string Role);

        Task LogoutAsync();
        Task GetUserByEmailAsync(object email);
    }
}
