using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
        private readonly Service_Request _service_request;

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
            DTO_Request dto_request = _service_request.Get_DTORequestsByID(id);
            if (dto_request != null)
            {
                return View(dto_request);
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
