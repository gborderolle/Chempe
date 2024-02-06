using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using System;
using System.Collections.Generic;

namespace Services.Chempe
{
    public class Service_Document
    {
        private readonly IConfiguration _configuration;
        private readonly Chempedb_context _chempedb_context;

        /* ------------ DYNAMIC ENTITIES ------------ */
        //private readonly Service_Person _service_Person;
        //private readonly Service_Photo _service_Photo;

        /* ------------ STATIC ENTITIES ------------ */


        public Service_Document(Chempedb_context chempedb_context, IConfiguration configuration/*, Service_Person service_Person, Service_Photo service_Photo*/)
        {
            _configuration = configuration;
            _chempedb_context = chempedb_context;
            //_service_Person = service_Person;
            //_service_Photo = service_Photo;
        }

        public DTO_Document UploadNewDocument(string identification, List<DTO_Photo> list_dto_photos = null)
        {
            Document document = null;
            if (!string.IsNullOrWhiteSpace(identification))
            {
                //Person person = _service_Person.Get_PersonByIdentification(identification);
                //if (person != null)
                //{
                //    List_documents_type list_documents_type = new("Person_identity", "Cedula");
                //    _chempedb_context.List_documents_type.Add(list_documents_type);

                //    document = new("CI", list_documents_type, null);

                //    List<Photo> list_photos = _service_Photo.ConverDTOList_toList(list_dto_photos);
                //    if (list_dto_photos != null && list_dto_photos.Count > 0)
                //    {
                //        document.List_photos = list_photos;
                //    }
                //    _chempedb_context.Document.Add(document);

                //    person.List_documents.Add(document);
                //    _chempedb_context.Person.Update(person);
                //}
                _chempedb_context.SaveChanges();
            }
            return Utls.mapper.Map<DTO_Document>(document);
        }
    }
}
