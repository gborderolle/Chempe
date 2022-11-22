using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Services.Chempe;
using Services.DTOs;
using System.Collections.Generic;

namespace Chempe.Controllers
{
    public class User_chempeController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_Person_client _service_User_client;
        private readonly Service_Person _service_person;

        /* ------------ STATIC ENTITIES ------------ */

        public User_chempeController(IWebHostEnvironment webHostEnvironment, Service_Logs service_logs, Service_Global_variables service_global_variables,
            Service_Person_client service_User_client, Service_Person service_person)
        {
            _webHostEnvironment = webHostEnvironment;
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_User_client = service_User_client;
            _service_person = service_person;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List_persons()
        {
            List<DTO_Person> list_dto_person = _service_person.Get_ListDTOPersons();
            if (list_dto_person != null)
            {
                return View(list_dto_person);
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            DTO_Person dto_person= _service_person.Get_DTOPersonByID(id);
            if (dto_person != null)
            {
                return View(dto_person);
            }
            return View();
        }

        public IActionResult Create_person()
        {
            return View();
        }

        public IActionResult List_user_clients()
        {
            return View();
        }
    }
}
