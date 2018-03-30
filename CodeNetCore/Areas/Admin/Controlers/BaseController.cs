using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeNetCore.Areas.Admin.Controlers
{
    [Area("Admin")]
    [Authorize]
    public class BaseController : Controller
    {
         
    }
}