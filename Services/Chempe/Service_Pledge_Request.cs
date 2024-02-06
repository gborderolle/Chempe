using Domain.Chempe;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using Services.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Services.Chempe
{
    public class Service_Pledge_Request
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Person_client _service_Person_client;
        //private readonly Service_Pledge _service_pledge;

        /* ------------ STATIC ENTITIES ------------ */

        public Service_Pledge_Request(Chempedb_context chempedb_context, IConfiguration configuration, Service_Person_client service_User_client/*, Service_Pledge service_pledge*/)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;

            _service_Person_client = service_User_client;
            //_service_pledge = service_pledge;
        }

        #region public methods

        public List<DTO_Pledge_Request> Get_ListDTORequests()
        {
            List<DTO_Pledge_Request> list_dto_request = new();
            List<Pledge_Request> list_request = _chempedb_context.Pledge_Request.Include(e => e.Person_client.Person).Include(e => e.Pledge).ToList();
            if (list_request != null && list_request.Count > 0)
            {
                foreach (Pledge_Request request in list_request)
                {
                    DTO_Pledge_Request dto_request = Utls.mapper.Map<DTO_Pledge_Request>(request);
                    list_dto_request.Add(dto_request);
                }
            }
            return list_dto_request;
        }

        public DTO_Pledge_Request Get_DTORequestByID(int id)
        {
            DTO_Pledge_Request dto_request = new();
            if (id > 0)
            {
                Pledge_Request request = _chempedb_context.Pledge_Request.Include(e => e.Person_client).Include(e => e.Pledge.Warrant_TV.Warrant_type).FirstOrDefault(e => e.Pledge_Request_ID == id);
                dto_request = Utls.mapper.Map<DTO_Pledge_Request>(request);
            }
            return dto_request;
        }

        #endregion

        #region CRUD methods

        public Pledge_Request Create_request(VM_Request_create vm_Request_create)
        {
            Pledge_Request request = new();
            Person_client user_client = _service_Person_client.GetUserById(vm_Request_create.Person_ID);
            if (user_client != null)
            {
                request.Person_client = user_client;

                _chempedb_context.Pledge_Request.Add(request);
                _chempedb_context.SaveChanges();
            }
            return request;
        }

        public void Create_request(DTO_Pledge_Request dto_request)
        {
            if (dto_request != null)
            {
                Pledge_Request request = Utls.mapper.Map<Pledge_Request>(dto_request);
                _chempedb_context.Pledge_Request.Add(request);
                _chempedb_context.SaveChanges();
            }
        }

        public void Update_request(DTO_Pledge_Request dto_Request)
        {
            if (dto_Request != null)
            {
                Pledge_Request request = Utls.mapper.Map<Pledge_Request>(dto_Request);
                if (request != null)
                {
                    _chempedb_context.Pledge_Request.Update(request);
                    _chempedb_context.SaveChanges();
                }
            }
        }

        public void Delete_request(int id)
        {
            if (id > 0)
            {
                DTO_Pledge_Request dto_Request = Get_DTORequestByID(id);
                if (dto_Request != null)
                {
                    Pledge_Request request = Utls.mapper.Map<Pledge_Request>(dto_Request);
                    if (request != null)
                    {
                        _chempedb_context.Pledge_Request.Remove(request);
                        _chempedb_context.SaveChanges();
                    }
                }
            }
        }

        #endregion

    }
}