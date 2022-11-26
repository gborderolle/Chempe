using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using Services.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Services.Chempe
{
    public class Service_Pledge_Approval
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Person_user _service_Person_user;
        
        /* ------------ STATIC ENTITIES ------------ */

        public Service_Pledge_Approval(Chempedb_context chempedb_context, IConfiguration configuration, Service_Person_user service_User_user)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;

            _service_Person_user = service_User_user;
        }

        #region public methods        

        public DTO_Pledge_Approval Get_DTOApprovalByID(int id)
        {
            DTO_Pledge_Approval dto_approval = new();
            if (id > 0)
            {
                Pledge_Approval approval = _chempedb_context.Pledge_Approval.FirstOrDefault(e => e.Pledge_Approval_ID == id);
                dto_approval = Utls.mapper.Map<DTO_Pledge_Approval>(approval);
            }
            return dto_approval;
        }

        public List<DTO_Pledge_Approval> Get_ListDTOApprovals()
        {
            List<DTO_Pledge_Approval> list_dto_approval = new();
            List<Pledge_Approval> list_approval = _chempedb_context.Pledge_Approval.ToList();
            if (list_approval != null && list_approval.Count > 0)
            {
                foreach (Pledge_Approval approval in list_approval)
                {
                    DTO_Pledge_Approval dto_approval = Utls.mapper.Map<DTO_Pledge_Approval>(approval);
                    list_dto_approval.Add(dto_approval);
                }
            }
            return list_dto_approval;
        }

        #endregion

        #region CRUD methods

        public Pledge_Approval Create_approval(VM_Approval_create vm_Approval_create)
        {
            Pledge_Approval approval = new();

            Person_user person_user = _service_Person_user.GetUserById(vm_Approval_create.Person_ID);
            if (person_user != null)
            {
                approval.Person_user = person_user;

                _chempedb_context.Pledge_Approval.Add(approval);
                _chempedb_context.SaveChanges();
            }
            return approval;
        }

        public void Create_approval(DTO_Pledge_Approval dto_approval)
        {
            if (dto_approval != null)
            {
                Pledge_Approval approval = Utls.mapper.Map<Pledge_Approval>(dto_approval);
                _chempedb_context.Pledge_Approval.Add(approval);
                _chempedb_context.SaveChanges();
            }
        }

        public void Update_approval(DTO_Pledge_Approval dto_Approval)
        {
            if (dto_Approval != null)
            {
                Pledge_Approval approval = Utls.mapper.Map<Pledge_Approval>(dto_Approval);
                if (approval != null)
                {
                    _chempedb_context.Pledge_Approval.Update(approval);
                    _chempedb_context.SaveChanges();
                }
            }
        }

        public void Delete_approval(int id)
        {
            if (id > 0)
            {
                DTO_Pledge_Approval dto_Approval = Get_DTOApprovalByID(id);
                if (dto_Approval != null)
                {
                    Pledge_Approval approval = Utls.mapper.Map<Pledge_Approval>(dto_Approval);
                    if (approval != null)
                    {
                        _chempedb_context.Pledge_Approval.Remove(approval);
                        _chempedb_context.SaveChanges();
                    }
                }
            }
        }


        #endregion

    }
}
