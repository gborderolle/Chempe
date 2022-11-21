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
        private readonly Service_Person _service_person;
        private readonly Service_User_client _service_User_client;

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
            if (id > 0)
            {
                DTO_Person dto_person = _service_person.Get_DTOPersonByID(id);
                if (dto_person != null)
                {
                    return View(dto_person);
                }
            }
            return View();
        }

        #region CRUD methods

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            if (ModelState.IsValid)
            {
                DTO_Person dto_person = new();
                TryUpdateModelAsync(dto_person);

                _service_person.Create_person(dto_person);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(int id)
        {
            if (id > 0)
            {
                DTO_Person dto_person = _service_person.Get_DTOPersonByID(id);
                if (dto_person != null)
                {
                    return View(dto_person);
                }
            }
            return View();
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            if (id > 0)
            {
                DTO_Person dto_person = _service_person.Get_DTOPersonByID(id);
                if (dto_person != null)
                {
                    TryUpdateModelAsync<IDTO_Person>(dto_person); // La interfaz protege los campos read-only del form (medida de Seguridad)
                    if (ModelState.IsValid)
                    {
                        _service_person.Update_person(dto_person);
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                _service_person.Delete_person(id);
                return RedirectToAction("Index");
            }
            return View();
        }

        #endregion CRUD methods


    }
}