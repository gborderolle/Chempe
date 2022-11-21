using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Chempe;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chempe.Controllers
{
    public class RequestController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_Request _service_request;
        private readonly Service_Person _service_person;
        private readonly Service_Warrant _service_Warrant;
        private readonly Service_Warrant_TV _service_Warrant_TV;

        /* ------------ STATIC ENTITIES ------------ */
        private readonly Service_List_TV_brands _service_List_TV_brands;
        private readonly Service_List_TV_brand_models _service_List_TV_brand_models;
        private readonly Service_List_TV_technologies _service_List_TV_technologies;
        private readonly Service_List_warrants_type _service_List_warrants_type;

        public RequestController(IWebHostEnvironment webHostEnvironment, Service_Logs service_logs, Service_Global_variables service_global_variables,
            Service_Request service_request, Service_Person service_person, Service_Warrant service_Warrant, Service_Warrant_TV service_Warrant_TV,
            Service_List_TV_brands service_List_TV_brands, Service_List_TV_brand_models service_List_TV_brand_models, Service_List_TV_technologies service_List_TV_technologies, Service_List_warrants_type service_List_warrants_type)
        {
            _webHostEnvironment = webHostEnvironment;
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_request = service_request;
            _service_person = service_person;
            _service_Warrant = service_Warrant;
            _service_Warrant_TV = service_Warrant_TV;

            _service_List_TV_brands = service_List_TV_brands;
            _service_List_TV_brand_models = service_List_TV_brand_models;
            _service_List_TV_technologies = service_List_TV_technologies;
            _service_List_warrants_type = service_List_warrants_type;

        }

        public IActionResult Index()
        {
            List<DTO_Request> list_dto_request = _service_request.Get_ListDTORequests();
            if (list_dto_request != null)
            {
                return View(list_dto_request);
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            DTO_Request dto_request = _service_request.Get_DTORequestByID(id);
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
                    DTO_Request_create dto_request_create = new();
                    dto_request_create.DTO_Person = dto_person;

                    // s: https://www.youtube.com/watch?v=ZUjOgrb4oHQ&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v&index=37&ab_channel=kudvenkat
                    ViewBag.List_DTO_List_warrants_type = new SelectList(_service_List_warrants_type.Get_DTO_List_warrants_type(), "DTO_List_warrants_type_ID");
                    ViewBag.List_DTO_List_TV_brands = new SelectList(_service_List_TV_brands.Get_DTO_List_TV_brands());
                    ViewBag.List_DTO_List_TV_brand_models = new SelectList(_service_List_TV_brand_models.Get_DTO_List_TV_brand_models());
                    ViewBag.List_DTO_List_TV_technologies = new SelectList(_service_List_TV_technologies.Get_DTO_List_TV_technologies());

                    return View(dto_request_create);
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
                DTO_Request_create dto_Request_create = new();
                TryUpdateModelAsync(dto_Request_create);
                //_service_Warrant.Create_warrant(dto_Warrant);

                // warrant_tv


                // request




                if (dto_Request_create.Warrant_type != null)
                {
                    //if (dto_Request_create.List_DTO_List_warrants_type == Service_Global_variables.Warrants_type_enum.Televisor.ToString())
                    {
                        //DTO_Warrant_TV dto_Warrant_tv = new();
                        //TryUpdateModelAsync(dto_Warrant_tv);
                        _service_Warrant_TV.Create_warrant_TV(dto_Request_create);
                    }
                    //else
                    {
                        //DTO_Warrant dto_Warrant = new();
                        //TryUpdateModelAsync(dto_Warrant);
                        _service_Warrant.Create_warrant(dto_Request_create);
                    }
                }

                //DTO_Request dto_request = new();
                //TryUpdateModelAsync(dto_request);
                _service_request.Create_request(dto_Request_create);

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
                DTO_Request dto_Request = _service_request.Get_DTORequestByID(id);
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
                DTO_Request dto_Request = _service_request.Get_DTORequestByID(id);
                if (dto_Request != null)
                {
                    TryUpdateModelAsync<IDTO_Request>(dto_Request); // La interfaz protege los campos read-only del form (medida de Seguridad)
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

        #endregion CRUD methods

    }
}
