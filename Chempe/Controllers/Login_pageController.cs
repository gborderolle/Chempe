using Domain.Chempe;
using Microsoft.AspNetCore.Mvc;
using Services.Chempe;
using Services.DTOs;
using Services.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chempe.Controllers
{
    public class Login_pageController : Controller
    {
        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_Person _service_person;
        private readonly Service_Session _service_session;

        /* ------------ STATIC ENTITIES ------------ */

        public Login_pageController(Service_Logs service_logs, Service_Global_variables service_global_variables, Service_Person service_person, Service_Session service_session)
        {
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_person = service_person;
            _service_session = service_session;
        }

        #region Pages 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string identification)
        {
            IActionResult login_result = RedirectToAction("Client_validation", "User_client");

            // Temporal ****
            if (!string.IsNullOrWhiteSpace(identification))
            {
                // Sistema de logs
                System.Diagnostics.StackTrace stackTrace = new(true);
                System.Diagnostics.StackFrame stackFrame = new();
                string className = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name;
                string methodName = stackFrame.GetMethod().Name;

                Person person = _service_person.Get_PersonByIdentification(identification);
                if (person != null)
                {
                    try
                    {
                        DTO_Login dto_login = new(person.Email, person.Password);
                        _service_session.Authenticate_user_client(person);


                        // Gonza
                        HttpContext.Session.Set("SessionUser", System.Text.UTF8Encoding.UTF8.GetBytes(person.Email));
                        // Gonza


                        _service_logs.Log_AgregarAccion("OK: Acceso al sistema correcto. Email: '" + dto_login.Email + "'. Passoword: '" + dto_login.Password + ".", string.Empty, person, GetIPAddress());

                        //***********************************

                        // Temporal **** Pruebas particulares:




                        //login_result = RedirectToAction("Client_validation", "User_client");
                        //login_result = RedirectToAction("New_request", "User_client");
                        //login_result = RedirectToAction("New_client", "User_client");
                        //login_result = RedirectToAction("Create", "Person");

                        //login_result = RedirectToAction("Dashboard", "User_client");
                        //login_result = RedirectToAction("Index", "Person");
                        //login_result = RedirectToAction("Index", "Pledge_Request");
                        //login_result = RedirectToAction("Index", "Pledge_Approval");

                        login_result = RedirectToAction("User_index", "Pledge_Request");

                    }
                    catch (Exception e)
                    {
                        _service_logs.Log_AgregarExcepcion("Excepcion. Haciendo login. ERROR:", className, methodName, e.Message);

                        // Temporal **** Pruebas particulares:
                        login_result = RedirectToAction("Index", "Home");
                    }
                }
            }
            // Temporal ****
            return login_result;
        }

        #endregion

        #region Public Methods 

        public string GetIPAddress()
        {
            string ipAddress_str = string.Empty;
            //var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;
            var ipAddress = this.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                ipAddress = this.Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            }
            if (ipAddress != null)
            {
                ipAddress_str = ipAddress.ToString();
            }
            return ipAddress_str;
        }

        #endregion

    }
}