using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Models;

namespace TravelCompany.Web.Helpers
{
    public interface IUserHelper
    {
        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }
}
