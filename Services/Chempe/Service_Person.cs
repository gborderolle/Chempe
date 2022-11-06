using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Models;
using Services.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Chempe
{
    public class Service_Person
    {
        private readonly IConfiguration _configuration;
        private readonly Chempedb_context _chempedb_context;
        private readonly Service_Global_variables _service_Global_variables;

        Configurations _configurations = new();

        public Service_Person(Chempedb_context chempedb_context, IConfiguration configuration, Service_Global_variables service_Global_variables)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
            _service_Global_variables = service_Global_variables;
        }

        #region Private methods

        public Person Get_PersonByIdentification(string identification)
        {
            Person person = new();
            if (!string.IsNullOrWhiteSpace(identification))
            {
                person = _chempedb_context.Person.FirstOrDefault(e => e.Identification == identification);
            }
            return person;
        }

        #endregion

        #region DTO methods

        public List<DTO_Document> Get_DTODocumentsIdentificationFromPersonByIdentification(string identification)
        {
            List<DTO_Document> list_documentsIdentification = new();
            if (!string.IsNullOrWhiteSpace(identification))
            {
                Person person = _chempedb_context.Person.FirstOrDefault(e => e.Identification == identification);
                if (person != null)
                {
                    if (person.List_documents != null && person.List_documents.Count > 0)
                    {
                        List<Document> list_documents = person.List_documents;
                        foreach (Document document in list_documents)
                        {
                            if (document.Documents_type != null)
                            {
                                if (!string.IsNullOrWhiteSpace(document.Documents_type.Name))
                                {
                                    if (document.Documents_type.Name == Service_Global_variables.Documents_type_enum.Person_identity.ToString())
                                    {
                                        DTO_Document document_aux = Utls.mapper.Map<DTO_Document>(document);
                                        list_documentsIdentification.Add(document_aux);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return list_documentsIdentification;
        }

        #endregion

        #region JSM methods

        public JSM_Person_User_client Get_JSMPersonByIdentification(string identification)
        {
            JSM_Person_User_client jsm_Person_User_client = new();
            if (!string.IsNullOrWhiteSpace(identification))
            {
                Person person = Get_PersonByIdentification(identification);
                if (person != null)
                {
                    jsm_Person_User_client.Person_ID = person.Person_ID;
                    jsm_Person_User_client.Full_name = person.Full_name;
                    jsm_Person_User_client.Email = person.Email;
                    jsm_Person_User_client.Password = person.Password;
                    jsm_Person_User_client.Identification = person.Identification;
                    jsm_Person_User_client.Gender = person.Gender;
                    jsm_Person_User_client.Date_born = person.Date_born;
                }
                if (person.User_client != null)
                {
                    jsm_Person_User_client.UserClient_ID = person.User_client.User_client_ID;
                }
                if (person.Photo != null)
                {
                    jsm_Person_User_client.Photo_ID = person.Photo.Photo_ID;
                    jsm_Person_User_client.Photo_URL = person.Photo.URL;
                    jsm_Person_User_client.Photo_Datetime_upload = person.Photo.Datetime_upload;
                }
                if (person.List_documents != null && person.List_documents.Count > 0)
                {
                    jsm_Person_User_client.Photo_ID = person.Photo.Photo_ID;
                    jsm_Person_User_client.Photo_URL = person.Photo.URL;
                    jsm_Person_User_client.Photo_Datetime_upload = person.Photo.Datetime_upload;
                }
            }
            return jsm_Person_User_client;
        }
        #endregion



    }
}
