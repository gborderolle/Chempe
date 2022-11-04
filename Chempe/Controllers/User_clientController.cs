using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chempe.Controllers
{
    public class User_clientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
            //return RedirectToAction("GMaps_inicio", "Dashboard");
        }

        public IActionResult New_client()
        {
            return View();
        }
    }
}
