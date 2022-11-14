using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Chempe;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace Chempe.Controllers
{
    public class User_clientController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;

            /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_User_client _service_user_client;
        private readonly Service_Person _service_Person;
        private readonly Service_Document _service_Document;
        private readonly Service_Photo _service_Photo;
        
            /* ------------ STATIC ENTITIES ------------ */
        private readonly Service_List_TV_brands _service_List_TV_brands;
        private readonly Service_List_TV_brand_models _service_List_TV_brand_models;
        private readonly Service_List_TV_technologies _service_List_TV_technologies;
        private readonly Service_List_warrants_type _service_List_warrants_type;

        public User_clientController(IWebHostEnvironment webHostEnvironment, Service_Logs service_logs, Service_Global_variables service_global_variables, 
            Service_User_client service_User_client, Service_Person service_person, Service_Document service_document, Service_Photo service_photo,
            Service_List_TV_brands service_List_TV_brands, Service_List_TV_brand_models service_List_TV_brand_models, Service_List_TV_technologies service_List_TV_technologies, Service_List_warrants_type service_List_warrants_type)
        {
            _webHostEnvironment = webHostEnvironment;
            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_user_client = service_User_client;
            _service_Person = service_person;
            _service_Document = service_document;
            _service_Photo = service_photo;

            _service_List_TV_brands = service_List_TV_brands;
            _service_List_TV_brand_models = service_List_TV_brand_models;
            _service_List_TV_technologies = service_List_TV_technologies;
            _service_List_warrants_type = service_List_warrants_type;
        }

        #region Pages 

        public IActionResult Index()
        {
            List<DTO_User_client> list_dto_user_client = _service_user_client.Get_ListDTOUser_clients();
            if (list_dto_user_client != null)
            {
                return View(list_dto_user_client);
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            DTO_User_client dto_user_client= _service_user_client.Get_DTOUser_clientByID(id);
            if (dto_user_client != null)
            {
                return View(dto_user_client);
            }
            return View();
        }

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
            List<DTO_Document> list_documents = new();
            string session_user = HttpContext.Session.GetString("SessionUser");
            if (!string.IsNullOrWhiteSpace(session_user))
            {
                DTO_Person dto_person = _service_Person.Get_DTOPersonByEmail(session_user);
                if (dto_person != null)
                {
                    DTO_New_request dto_new_request = new ();
                    dto_new_request.DTO_Person = dto_person;
                    dto_new_request.List_DTO_List_warrants_type = _service_List_warrants_type.Get_DTO_List_warrants_type();
                    dto_new_request.List_DTO_List_TV_brands = _service_List_TV_brands.Get_DTO_List_TV_brands();
                    dto_new_request.List_DTO_List_TV_brand_models = _service_List_TV_brand_models.Get_DTO_List_TV_brand_models();
                    dto_new_request.List_DTO_List_TV_technologies = _service_List_TV_technologies.Get_DTO_List_TV_technologies();

                    return View(dto_new_request);
                }
            }
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// ToDo: Hacer caso que ya tenga precargados los documentos de identidad
        /// ToDo: Permitir borrar los documentos
        /// </summary>
        /// <returns></returns>
        public IActionResult Client_validation()
        {
            List<DTO_Document> list_documents = new();
            string session_user = HttpContext.Session.GetString("SessionUser");
            if (!string.IsNullOrWhiteSpace(session_user))
            {
                DTO_Person dto_person = _service_Person.Get_DTOPersonByEmail(session_user);
                if (dto_person != null)
                {
                    list_documents = _service_Person.Get_DTODocumentsIdentificationFromPersonByIdentification(dto_person.Identification);
                    if (list_documents == null)
                    {
                        list_documents = new();
                    }

                    DTO_Client_validation dto_client_validation = new ();
                    dto_client_validation.DTO_Person = dto_person;
                    dto_client_validation.List_DTO_documents_identity = list_documents;

                    return View(dto_client_validation);
                }
            }
            return RedirectToAction("Index", "Home");
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
                result = _service_user_client.New_user_client(input_name, input_phone, input_borndate, input_email, input_password1, input_identity);

            }
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> UploadFile()
        {
            string result = string.Empty;

            // Sistema de logs
            System.Diagnostics.StackTrace stackTrace = new(true);
            System.Diagnostics.StackFrame stackFrame = new();
            string className = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name;
            string methodName = stackFrame.GetMethod().Name;

            // Hacer este:
            // https://stackoverflow.com/questions/46549746/using-ajax-to-post-a-view-model-which-includes-an-iformfile-property-in-mvc-core

            if (Request.Form != null && Request.Form["file_data"][0] != null)
            {
                string person_identification = Request.Form["file_data"][0];
                if (!string.IsNullOrWhiteSpace(person_identification))
                {
                    List<DTO_Photo> list_dto_photos = new();

                    // s: https://www.youtube.com/watch?v=hLJzTcOFthw&ab_channel=NihiraTechiees
                    var files = Request.Form.Files;
                    int photo_number = 1;
                    foreach (IFormFile source in files)
                    {
                        string photo_description = photo_number == 1 ? Service_Global_variables.Nombres_espanol_enum.Documento_de_identidad + " frente" : Service_Global_variables.Nombres_espanol_enum.Documento_de_identidad + " dorso";

                        // Creación de la imagen bd
                        DTO_Photo dto_photo = _service_Photo.UploadNewPhoto(person_identification, photo_description);
                        if (dto_photo != null)
                        {
                            if (!string.IsNullOrWhiteSpace(dto_photo.Filename))
                            {
                                // Creación de la imagen real
                                string file_name = dto_photo.Filename + ".jpg";
                                string full_path = _webHostEnvironment.WebRootPath + "\\uploads\\user_client\\" + person_identification + "\\documents\\";
                                try
                                {
                                    if (!Directory.Exists(Path.GetDirectoryName(full_path)))
                                    {
                                        Directory.CreateDirectory(Path.GetDirectoryName(full_path));
                                    }
                                    string image_path = Path.Combine(full_path, file_name);
                                    if (System.IO.File.Exists(image_path))
                                    {
                                        System.IO.File.Delete(image_path);
                                    }
                                    using (FileStream stream = System.IO.File.Create(image_path))
                                    {
                                        await source.CopyToAsync(stream);
                                        result = "Ok";
                                    }
                                }
                                catch (Exception ex)
                                {
                                    _service_logs.Log_AgregarExcepcion("Excepcion. Conectando a la API Chirpstack. ERROR:", className, methodName, ex.Message);
                                }
                            }
                            list_dto_photos.Add(dto_photo);
                        }
                        photo_number++;
                    } //foreach

                    // Creación del documento y guarda sus imágenes
                    _service_Document.UploadNewDocument(person_identification, list_dto_photos);
                }
            }
            return Ok(result);
        }

        public string GetActualPath(string file_name)
        {
            return Path.Combine(_webHostEnvironment.WebRootPath + "\\uploads\\user_client\\", file_name);
        }



        #endregion
    }
}
