using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Services.Chempe;
using Services.DTOs;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Chempe.Controllers
{
    public class User_clientController : Controller
    {
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_User_client _service_User_client;
        private readonly Service_Person _service_Person;

        public User_clientController(Service_Logs service_logs, Service_Global_variables service_global_variables, Service_User_client service_User_client, Service_Person service_Person)
        {
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_User_client = service_User_client;
            _service_Person = service_Person;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Pages 

        public IActionResult Dashboard()
        {
            return View();
            //return RedirectToAction("GMaps_inicio", "Dashboard");
        }

        public IActionResult New_client()
        {
            return View();
        }

        public IActionResult New_request()
        {
            return View();
        }

        public IActionResult client_validation(string identification)
        {
            List<DTO_Document> list_documents = _service_Person.Get_DTODocumentsIdentificationFromPersonByIdentification(identification);
            if (list_documents == null)
            {
                list_documents = new();
            }
            //return View(list_documents);
            return View();
        }

        #endregion

        #region Llamadas Ajax 

        [HttpPost]
        public bool Add_user_client(string input_name, string input_phone, string input_borndate, string input_email, string input_password1, string input_identity)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(input_name) && !string.IsNullOrWhiteSpace(input_phone) &&
                !string.IsNullOrWhiteSpace(input_borndate) && !string.IsNullOrWhiteSpace(input_email) &&
                !string.IsNullOrWhiteSpace(input_password1) && !string.IsNullOrWhiteSpace(input_identity))
            {
                result = _service_User_client.New_user_client(input_name, input_phone, input_borndate, input_email, input_password1, input_identity);

            }
            return result;
        }

        #endregion
    }
}
