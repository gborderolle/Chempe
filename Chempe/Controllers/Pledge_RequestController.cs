﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Chempe;
using Services.DTOs;
using Services.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Chempe.Controllers
{
    public class Pledge_RequestController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_Pledge_Request _service_request;
        private readonly Service_Person _service_person;
        private readonly Service_Warrant _service_warrant;
        private readonly Service_Warrant_TV _service_warrant_TV;
        private readonly Service_Pledge _service_pledge;

        /* ------------ STATIC ENTITIES ------------ */
        private readonly Service_List_TV_brands _service_List_TV_brands;
        private readonly Service_List_TV_brand_models _service_List_TV_brand_models;
        private readonly Service_List_TV_technologies _service_List_TV_technologies;
        private readonly Service_List_warrants_type _service_List_warrants_type;

        public Pledge_RequestController(IWebHostEnvironment webHostEnvironment, Service_Logs service_logs, Service_Global_variables service_global_variables,
            Service_Pledge_Request service_request, Service_Person service_person, Service_Warrant service_Warrant, Service_Warrant_TV service_Warrant_TV, Service_Pledge service_pledge,
            Service_List_TV_brands service_List_TV_brands, Service_List_TV_brand_models service_List_TV_brand_models, Service_List_TV_technologies service_List_TV_technologies, Service_List_warrants_type service_List_warrants_type)
        {
            _webHostEnvironment = webHostEnvironment;
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_request = service_request;
            _service_person = service_person;
            _service_warrant = service_Warrant;
            _service_warrant_TV = service_Warrant_TV;
            _service_pledge = service_pledge;

            _service_List_TV_brands = service_List_TV_brands;
            _service_List_TV_brand_models = service_List_TV_brand_models;
            _service_List_TV_technologies = service_List_TV_technologies;
            _service_List_warrants_type = service_List_warrants_type;
        }

        public IActionResult Index()
        {
            List<DTO_Pledge_Request> list_dto_request = _service_request.Get_ListDTORequests();
            if (list_dto_request != null)
            {
                return View(list_dto_request);
            }
            return View();
        }

        public IActionResult Client_index()
        {
            List<DTO_Pledge_Request> list_dto_request = _service_request.Get_ListDTORequests();
            if (list_dto_request != null)
            {
                return View(list_dto_request);
            }
            return View();
        }
        
        public IActionResult User_index()
        {
            List<DTO_Pledge_Request> list_dto_request = _service_request.Get_ListDTORequests();
            if (list_dto_request != null)
            {
                return View(list_dto_request);
            }
            return View();
        }

        public IActionResult Client_details(int id)
        {
            DTO_Pledge_Request dto_request = _service_request.Get_DTORequestByID(id);
            if (dto_request != null)
            {
                return View(dto_request);
            }
            return View();
        }

        public IActionResult User_details(int id)
        {
            if (id > 0)
            {
                return RedirectToAction("Create", "Pledge_Approval", new { DTO_Pledge_Request_ID = id });
            }
            return RedirectToAction("Index", "Home");
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

                    // Warrant type
                    List<DTO_List_warrants_type> DTO_List_warrants_type = _service_List_warrants_type.Get_DTO_List_warrants_type();
                    var selectList = new List<SelectListItem>();
                    foreach (var element in DTO_List_warrants_type)
                    {
                        selectList.Add(new SelectListItem
                        {
                            Value = element.List_warrants_type_ID.ToString(),
                            Text = element.Name
                        });
                    }
                    ViewBag.List_DTO_List_warrants_type = selectList;

                    // Brand
                    List<DTO_List_TV_brands> DTO_List_TV_brands = _service_List_TV_brands.Get_DTO_List_TV_brands();
                    selectList = new List<SelectListItem>();
                    foreach (var element in DTO_List_TV_brands)
                    {
                        selectList.Add(new SelectListItem
                        {
                            Value = element.List_TV_brands_ID.ToString(),
                            Text = element.Name
                        });
                    }
                    ViewBag.List_DTO_List_TV_brands = selectList;

                    // Model
                    ViewBag.List_DTO_List_TV_brand_models = new List<SelectListItem>();

                    // Technology
                    List<DTO_List_TV_technologies> DTO_List_TV_technologies = _service_List_TV_technologies.Get_DTO_List_TV_technologies();
                    selectList = new List<SelectListItem>();
                    foreach (var element in DTO_List_TV_technologies)
                    {
                        selectList.Add(new SelectListItem
                        {
                            Value = element.List_TV_technologies_ID.ToString(),
                            Text = element.Name
                        });
                    }
                    ViewBag.List_DTO_List_TV_technologies = selectList;

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
                DTO_Pledge_Request dto_Request = _service_request.Get_DTORequestByID(id);
                if (dto_Request != null)
                {
                    return View(dto_Request);
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
                DTO_Pledge_Request dto_Request = _service_request.Get_DTORequestByID(id);
                if (dto_Request != null)
                {
                    TryUpdateModelAsync<IDTO_Pledge_Request>(dto_Request); // La interfaz protege los campos read-only del form (medida de Seguridad)
                    if (ModelState.IsValid)
                    {
                        _service_request.Update_request(dto_Request);
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

        #endregion 

        #region Ajax calls

        [HttpPost]
        public JsonResult GetModelsByBrandID(string ddl_brand) //It will be fired from Jquery ajax call
        {
            JsonResult result = null;
            if (!string.IsNullOrWhiteSpace(ddl_brand))
            {
                result = Json(_service_List_TV_brand_models.GetJSM_List_TV_brand_modelsByBrandID(ddl_brand));
            }
            return result;
        }

        #endregion

    }
}
