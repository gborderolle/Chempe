using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Chempe
{
    public class Service_Request
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        Configurations _configurations = new();

        public Service_Request(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

        #region public methods

        public List<DTO_Request> Get_ListDTORequests()
        {
            List<DTO_Request> list_dto_request = new();
            List<Request> list_request = _chempedb_context.Request.ToList();
            if (list_request != null && list_request.Count > 0)
            {
                foreach (Request request in list_request)
                {
                    DTO_Request dto_request = Utls.mapper.Map<DTO_Request>(request);
                    list_dto_request.Add(dto_request);
                }
            }
            return list_dto_request;
        }

        public DTO_Request Get_DTORequestByID(int id)
        {
            DTO_Request dto_request = new();
            if (id > 0)
            {
                Request request = _chempedb_context.Request.FirstOrDefault(e => e.Request_ID == id);
                dto_request = Utls.mapper.Map<DTO_Request>(request);
            }
            return dto_request;
        }

        #endregion

        #region CRUD methods

        public void Create_request(DTO_Request dto_request)
        {
            if (dto_request != null)
            {
                Request request = Utls.mapper.Map<Request>(dto_request);
                _chempedb_context.Request.Add(request);
                _chempedb_context.SaveChanges();
            }
        }

        public void Update_request(DTO_Request dto_Request)
        {
            if (dto_Request != null)
            {
                Request request = Utls.mapper.Map<Request>(dto_Request);
                if (request != null)
                {
                    _chempedb_context.Request.Update(request);
                    _chempedb_context.SaveChanges();
                }
            }
        }

        public void Delete_request(int id)
        {
            if (id > 0)
            {
                DTO_Request dto_Request = Get_DTORequestByID(id);
                if (dto_Request != null)
                {
                    Request request = Utls.mapper.Map<Request>(dto_Request);
                    if (request != null)
                    {
                        _chempedb_context.Request.Remove(request);
                        _chempedb_context.SaveChanges();
                    }
                }
            }
        }

        public Request Create_request(VM_Request_create vm_Request_create)
        {
            Request request = new();
            request.Inches = vm_Request_create.Inches;
            request.IsSmart = vm_Request_create.IsSmart;


            request.TV_Brand = _service_List_TV_brands.GetBrandByID(vm_Request_create.Brand_ID);
            request.TV_brand_model = _service_List_TV_brand_models.GetModelByID(vm_Request_create.Model_ID);
            request.TV_technology = _service_List_TV_technologies.GetTechnologyByID(vm_Request_create.Technology_ID);


            _chempedb_context.Request.Add(request);
            _chempedb_context.SaveChanges();

            return request;
        }


        #endregion

    }
}