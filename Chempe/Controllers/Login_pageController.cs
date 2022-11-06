using Microsoft.AspNetCore.Mvc;
using Services.Chempe;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chempe.Controllers
{
    public class Login_pageController : Controller
    {
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_Person _service_Person;

        public Login_pageController(Service_Logs service_logs, Service_Global_variables service_global_variables, Service_Person service_Person)
        {
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_Person = service_Person;
        }

        #region Pages 

        public IActionResult Login(string identification)
        {
            // Temporal ****
            if (!string.IsNullOrWhiteSpace(identification))
            {
                DTO_Person dto_person = _service_Person.Get_DTOPersonByIdentification(identification);
                if (dto_person != null)
                {
                    //HttpContext.Session["Person_login"] = dto_person;
                    return RedirectToAction("User_client", "Client_validation2");
                }
            }
            // Temporal ****
            return View();
        }

        #endregion
    }
}
