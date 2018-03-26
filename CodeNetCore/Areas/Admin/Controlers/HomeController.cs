using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeNetCore.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CodeNetCore.Areas.Admin.Controlers
{
    public class HomeController : Controller
    {

        [Area("Admin")]
        public IActionResult Index()
        {
            var email = User.GetspecificClaim("Email");
            return View();
        }
    }
}