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
    public class Service_Pledge_Acceptance
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Person_client _service_Person_client;

        /* ------------ STATIC ENTITIES ------------ */


        public Service_Pledge_Acceptance(Chempedb_context chempedb_context, IConfiguration configuration, Service_Person_client service_User_user)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;

            _service_Person_client = service_User_user;
        }

        #region public methods        

        public DTO_Pledge_Acceptance Get_DTOApprovalByID(int id)
        {
            DTO_Pledge_Acceptance dto_acceptance = new();
            if (id > 0)
            {
                Pledge_Acceptance acceptance = _chempedb_context.Pledge_Acceptance.FirstOrDefault(e => e.Pledge_Acceptance_ID == id);
                dto_acceptance = Utls.mapper.Map<DTO_Pledge_Acceptance>(acceptance);
            }
            return dto_acceptance;
        }

        public List<DTO_Pledge_Acceptance> Get_ListDTOApprovals()
        {
            List<DTO_Pledge_Acceptance> list_dto_acceptance = new();
            List<Pledge_Acceptance> list_acceptance = _chempedb_context.Pledge_Acceptance.ToList();
            if (list_acceptance != null && list_acceptance.Count > 0)
            {
                foreach (Pledge_Acceptance acceptance in list_acceptance)
                {
                    DTO_Pledge_Acceptance dto_acceptance = Utls.mapper.Map<DTO_Pledge_Acceptance>(acceptance);
                    list_dto_acceptance.Add(dto_acceptance);
                }
            }
            return list_dto_acceptance;
        }

        #endregion

        #region CRUD methods

        public Pledge_Acceptance Create_acceptance(VM_Approval_create vm_Approval_create)
        {
            Pledge_Acceptance acceptance = new();

            //Person_client person_client = _service_Person_client.GetUserById(vm_Approval_create.Person_ID);
            //if (person_client != null)
            //{
            //    acceptance.Person_client = person_client;

            //    _chempedb_context.Pledge_Acceptance.Add(acceptance);
            //    _chempedb_context.SaveChanges();
            //}
            return acceptance;
        }

        public void Create_acceptance(DTO_Pledge_Acceptance dto_acceptance)
        {
            if (dto_acceptance != null)
            {
                Pledge_Acceptance acceptance = Utls.mapper.Map<Pledge_Acceptance>(dto_acceptance);
                _chempedb_context.Pledge_Acceptance.Add(acceptance);
                _chempedb_context.SaveChanges();
            }
        }

        public DTO_Pledge_Acceptance Get_DTOAcceptanceByID(int id)
        {
            DTO_Pledge_Acceptance dto_acceptance = new();
            if (id > 0)
            {
                Pledge_Acceptance acceptance = _chempedb_context.Pledge_Acceptance.FirstOrDefault(e => e.Pledge_Acceptance_ID == id);
                dto_acceptance = Utls.mapper.Map<DTO_Pledge_Acceptance>(acceptance);
            }
            return dto_acceptance;
        }

        public List<DTO_Pledge_Acceptance> Get_ListDTOAcceptances()
        {
            List<DTO_Pledge_Acceptance> list_dto_acceptance = new();
            List<Pledge_Acceptance> list_acceptance = _chempedb_context.Pledge_Acceptance.ToList();
            if (list_acceptance != null && list_acceptance.Count > 0)
            {
                foreach (Pledge_Acceptance acceptance in list_acceptance)
                {
                    DTO_Pledge_Acceptance dto_acceptance = Utls.mapper.Map<DTO_Pledge_Acceptance>(acceptance);
                    list_dto_acceptance.Add(dto_acceptance);
                }
            }
            return list_dto_acceptance;
        }

        public void Update_acceptance(DTO_Pledge_Acceptance dto_Approval)
        {
            if (dto_Approval != null)
            {
                Pledge_Acceptance acceptance = Utls.mapper.Map<Pledge_Acceptance>(dto_Approval);
                if (acceptance != null)
                {
                    _chempedb_context.Pledge_Acceptance.Update(acceptance);
                    _chempedb_context.SaveChanges();
                }
            }
        }

        public void Delete_acceptance(int id)
        {
            if (id > 0)
            {
                DTO_Pledge_Acceptance dto_Approval = Get_DTOApprovalByID(id);
                if (dto_Approval != null)
                {
                    Pledge_Acceptance acceptance = Utls.mapper.Map<Pledge_Acceptance>(dto_Approval);
                    if (acceptance != null)
                    {
                        _chempedb_context.Pledge_Acceptance.Remove(acceptance);
                        _chempedb_context.SaveChanges();
                    }
                }
            }
        }

        #endregion

    }
}