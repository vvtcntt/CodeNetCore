using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeNetCore.Data.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeNetCore.Areas.Admin.Controlers
{
     public class AccountController :BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController (SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Admin/Login/Index");
        }
    }
}