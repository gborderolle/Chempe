using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chempe.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test_fileUpload()
        {
            DTO_Testing dto_testing = new();
            //dto_testing.Message2 = "Holanda";

            //return View(dto_testing);
            return View();
        }
    }
}
