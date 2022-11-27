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
    public class Pledge_ApprovalController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_Pledge_Approval _service_approval;
        private readonly Service_Pledge_Request _service_request;
        private readonly Service_Person _service_person;
        private readonly Service_Warrant _service_warrant;
        private readonly Service_Warrant_TV _service_warrant_TV;
        private readonly Service_Pledge _service_pledge;

        /* ------------ STATIC ENTITIES ------------ */

        public Pledge_ApprovalController(IWebHostEnvironment webHostEnvironment, Service_Logs service_logs, Service_Global_variables service_global_variables,
            Service_Pledge_Approval service_approval, Service_Pledge_Request service_request, Service_Person service_person, Service_Warrant service_Warrant, Service_Warrant_TV service_Warrant_TV, Service_Pledge service_pledge)
        {
            _webHostEnvironment = webHostEnvironment;
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_approval = service_approval;
            _service_request = service_request;
            _service_person = service_person;
            _service_warrant = service_Warrant;
            _service_warrant_TV = service_Warrant_TV;
            _service_pledge = service_pledge;
        }

        public IActionResult Index()
        {
            List<DTO_Pledge_Approval> list_dto_request = _service_approval.Get_ListDTOApprovals();
            if (list_dto_request != null)
            {
                return View(list_dto_request);
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            DTO_Pledge_Approval dto_request = _service_approval.Get_DTOApprovalByID(id);
            if (dto_request != null)
            {
                return View(dto_request);
            }
            return View();
        }

        #region CRUD methods

        [HttpGet]
        [ActionName("Create")]
        public IActionResult Create_Get(int DTO_Pledge_Request_ID)
        {
            if (DTO_Pledge_Request_ID > 0)
            {
                DTO_Pledge_Request dto_request = _service_request.Get_DTORequestByID(DTO_Pledge_Request_ID);
                if (dto_request != null && dto_request.Pledge != null)
                {
                    VM_Approval_create vm_Approval_create = new();
                    vm_Approval_create.DTO_Pledge = dto_request.Pledge;
                    return View(vm_Approval_create);
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
                DTO_Pledge_Approval dto_Approval = _service_approval.Get_DTOApprovalByID(id);
                if (dto_Approval != null)
                {
                    return View(dto_Approval);
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
                DTO_Pledge_Approval dto_Approval = _service_approval.Get_DTOApprovalByID(id);
                if (dto_Approval != null)
                {
                    TryUpdateModelAsync<IDTO_Pledge_Approval>(dto_Approval); // La interfaz protege los campos read-only del form (medida de Seguridad)
                    if (ModelState.IsValid)
                    {
                        _service_approval.Update_approval(dto_Approval);
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
