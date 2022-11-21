using Domain.Chempe;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
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

        #endregion

        #region Public methods

        public Person Get_PersonByID(int person_ID)
        {
            return _chempedb_context.Person.Include("List_documents.List_photos").FirstOrDefault(e => e.Person_ID == person_ID);
        }

        public DTO_Person Get_DTOPersonByEmail(string email)
        {
            DTO_Person dto_person = new();
            if (!string.IsNullOrWhiteSpace(email))
            {
                Person person = _chempedb_context.Person.Include("List_documents.Documents_type").FirstOrDefault(e => e.Email == email);
                dto_person = Utls.mapper.Map<DTO_Person>(person);
            }
            return dto_person;
        }

        public DTO_Person Get_DTOPersonByID(int id)
        {
            DTO_Person dto_person = new();
            if (id > 0)
            {
                Person person = _chempedb_context.Person.Single(e => e.Person_ID == id);
                dto_person = Utls.mapper.Map<DTO_Person>(person);
            }
            return dto_person;
        }

        public List<DTO_Person> Get_ListDTOPersons()
        {
            List<DTO_Person> list_dto_person = new();
            List<Person> list_person = _chempedb_context.Person.ToList();
            if (list_person != null && list_person.Count > 0)
            {
                foreach (Person person in list_person)
                {
                    DTO_Person dto_person = Utls.mapper.Map<DTO_Person>(person);
                    list_dto_person.Add(dto_person);
                }
            }
            return list_dto_person;
        }

        public int Get_CountTotalPhotosByIdentification(string identification)
        {
            int result = 0;
            if (!string.IsNullOrWhiteSpace(identification))
            {
                List<Document> list_documentsOfIdentification = new();
                Person person = _chempedb_context.Person.Include("List_documents.Documents_type").FirstOrDefault(e => e.Identification == identification);
                if (person != null)
                {
                    List<Document> list_documents = person.List_documents;
                    foreach (Document document in list_documents)
                    {
                        if (document.List_photos != null)
                        {
                            result = +document.List_photos.Count;
                        }
                    }// foreach
                }
            }
            return result;
        }

        public DTO_Person Get_DTOPersonByIdentification(string identification)
        {
            DTO_Person dto_person = new();
            if (!string.IsNullOrWhiteSpace(identification))
            {
                Person person = _chempedb_context.Person.Include("List_documents.Documents_type").FirstOrDefault(e => e.Identification == identification);
                dto_person = Utls.mapper.Map<DTO_Person>(person);
            }
            return dto_person;
        }

        public Person Get_PersonByIdentification(string identification)
        {
            Person person = new();
            if (!string.IsNullOrWhiteSpace(identification))
            {
                person = _chempedb_context.Person.Include("List_documents.Documents_type").FirstOrDefault(e => e.Identification == identification);
            }
            return person;
        }

        public List<DTO_Document> Get_DTODocumentsIdentificationFromPersonByIdentification(string identification)
        {
            List<DTO_Document> list_dto_documentsOfIdentification = new();
            if (!string.IsNullOrWhiteSpace(identification))
            {
                Person person = _chempedb_context.Person.Include("List_documents.List_photos").
                    Include("List_documents.Documents_type").FirstOrDefault(e => e.Identification == identification);
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
                                        DTO_Document dto_document = Utls.mapper.Map<DTO_Document>(document);
                                        list_dto_documentsOfIdentification.Add(dto_document);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return list_dto_documentsOfIdentification;
        }

        #endregion

        #region CRUD methods

        public void Create_person(DTO_Person dto_person)
        {
            if (dto_person != null)
            {
                Person person = Utls.mapper.Map<Person>(dto_person);
                _chempedb_context.Person.Add(person);
                _chempedb_context.SaveChanges();
            }
        }

        public void Update_person(DTO_Person dto_person)
        {
            if (dto_person != null)
            {
                Person person = Utls.mapper.Map<Person>(dto_person);
                if (person != null)
                {
                    _chempedb_context.Person.Update(person);
                    _chempedb_context.SaveChanges();
                }
            }
        }

        public void Delete_person(int id)
        {
            if (id > 0)
            {
                DTO_Person dto_person = Get_DTOPersonByID(id);
                if (dto_person != null)
                {
                    Person person = Utls.mapper.Map<Person>(dto_person);
                    if (person != null)
                    {
                        _chempedb_context.Person.Remove(person);
                        _chempedb_context.SaveChanges();
                    }
                }
            }
        }

        #endregion




    }
}
