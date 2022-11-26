using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Chempe;
using Services.DTOs;
using Services.ViewModels;
using System.Collections.Generic;

namespace Chempe.Controllers
{
    public class Pledge_AcceptanceController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_Pledge_Acceptance _service_acceptance;
        private readonly Service_Person _service_person;
        private readonly Service_Warrant _service_warrant;
        private readonly Service_Warrant_TV _service_warrant_TV;
        private readonly Service_Pledge _service_pledge;

        /* ------------ STATIC ENTITIES ------------ */

        public Pledge_AcceptanceController(IWebHostEnvironment webHostEnvironment, Service_Logs service_logs, Service_Global_variables service_global_variables,
            Service_Pledge_Acceptance service_acceptance, Service_Person service_person, Service_Warrant service_Warrant, Service_Warrant_TV service_Warrant_TV, Service_Pledge service_pledge)
        {
            _webHostEnvironment = webHostEnvironment;
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_acceptance = service_acceptance;
            _service_person = service_person;
            _service_warrant = service_Warrant;
            _service_warrant_TV = service_Warrant_TV;
            _service_pledge = service_pledge;
        }

        public IActionResult Index()
        {
            List<DTO_Pledge_Acceptance> list_dto_request = _service_acceptance.Get_ListDTOAcceptances();
            if (list_dto_request != null)
            {
                return View(list_dto_request);
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            DTO_Pledge_Acceptance dto_request = _service_acceptance.Get_DTOAcceptanceByID(id);
            if (dto_request != null)
            {
                return View(dto_request);
            }
            return View();
        }

        #region CRUD methods

        [HttpGet]
        [ActionName("Create")]
        public IActionResult Create_Get()
        {
            List<DTO_Document> list_documents = new();
            string session_user = HttpContext.Session.GetString("SessionUser");
            if (!string.IsNullOrWhiteSpace(session_user))
            {
                DTO_Person dto_person = _service_person.Get_DTOPersonByEmail(session_user);
                if (dto_person != null)
                {
                    VM_Request_create vm_Request_create = new();
                    vm_Request_create.Person_ID = dto_person.Person_ID; //ToDo: resolver ID. User_client hereda de Person? o un Person tiene uno de cada tipo?

                    // ToDo

                    return View(vm_Request_create);
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            if (ModelState.IsValid)
            {
                VM_Request_create vm_Request_create = new();
                TryUpdateModelAsync(vm_Request_create);

                _service_pledge.Create_Pledge(vm_Request_create);

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
                DTO_Pledge_Acceptance dto_Acceptance = _service_acceptance.Get_DTOAcceptanceByID(id);
                if (dto_Acceptance != null)
                {
                    return View(dto_Acceptance);
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
                DTO_Pledge_Acceptance dto_Acceptance = _service_acceptance.Get_DTOAcceptanceByID(id);
                if (dto_Acceptance != null)
                {
                    TryUpdateModelAsync<IDTO_Pledge_Acceptance>(dto_Acceptance); // La interfaz protege los campos read-only del form (medida de Seguridad)
                    if (ModelState.IsValid)
                    {
                        _service_acceptance.Update_acceptance(dto_Acceptance);
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
