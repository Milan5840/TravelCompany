using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Helpers;
using TravelCompany.Web.Models;

namespace TravelCompany.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;

        public AccountController(IUserHelper userHelper) 
        {
            _userHelper = userHelper;
        }

        public IActionResult Login() {

            if (User.Identity.IsAuthenticated) {

                return RedirectToAction("Index", "Home"); 
            }
            return View();
        }

        public async Task<IActionResult> Login(LoginViewModel model) {

            if (ModelState.IsValid) {

                var result = await _userHelper.LoginAsync(model);
                if (result.Succeeded) {

                    if (Request.Query.Keys.Contains("ReturnUrl")) {

                        return Redirect(Request.Query["ReturnUrl"].First());
                    }

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Failed To Login");
            return View(model);
        }

        public async Task<IActionResult> Logout() 
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        
        }

    }
}
