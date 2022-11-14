using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Chempe;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Chempe.Controllers
{
    public class PersonController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_User_client _service_User_client;
        private readonly Service_Person _service_person;

        /* ------------ STATIC ENTITIES ------------ */

        public PersonController(IWebHostEnvironment webHostEnvironment, Service_Logs service_logs, Service_Global_variables service_global_variables,
            Service_User_client service_User_client, Service_Person service_person)
        {
            _webHostEnvironment = webHostEnvironment;
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_User_client = service_User_client;
            _service_person = service_person;
        }

        public IActionResult Index()
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
            DTO_Person dto_person = _service_person.Get_DTOPersonByID(id);
            if (dto_person != null)
            {
                return View(dto_person);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(IFormCollection formCollection)
        {
            DTO_Person dto_person = new();
            dto_person.Identification = formCollection["Identification"];
            dto_person.Full_name = formCollection["Full_name"];
            dto_person.Email = formCollection["Email"];
            dto_person.Password = formCollection["Password"];
            dto_person.Gender = formCollection["Gender"];

            DateTime date_born_out = DateTime.MinValue;
            if (!DateTime.TryParseExact(formCollection["Date_born"], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date_born_out))
            {
                date_born_out = DateTime.MinValue;
            }
            dto_person.Date_born = date_born_out;
            _service_person.Create_person(dto_person);
            return RedirectToAction("Index");
        }
    }
}