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
    public class Service_Pledge_Assignment
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Person_investor _service_Person_investor;
        
        /* ------------ STATIC ENTITIES ------------ */


        public Service_Pledge_Assignment(Chempedb_context chempedb_context, IConfiguration configuration, Service_Person_investor service_User_user)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;

            _service_Person_investor = service_User_user;
        }


        #region public methods        

        public DTO_Pledge_Assignment Get_DTOAssignmentByID(int id)
        {
            DTO_Pledge_Assignment dto_assignment = new();
            if (id > 0)
            {
                Pledge_Assignment assignment = _chempedb_context.Assignment.FirstOrDefault(e => e.Pledge_Assignment_ID == id);
                dto_assignment = Utls.mapper.Map<DTO_Pledge_Assignment>(assignment);
            }
            return dto_assignment;
        }

        public List<DTO_Pledge_Assignment> Get_ListDTOAssignments()
        {
            List<DTO_Pledge_Assignment> list_dto_assignment = new();
            List<Pledge_Assignment> list_assignment = _chempedb_context.Assignment.ToList();
            if (list_assignment != null && list_assignment.Count > 0)
            {
                foreach (Pledge_Assignment assignment in list_assignment)
                {
                    DTO_Pledge_Assignment dto_assignment = Utls.mapper.Map<DTO_Pledge_Assignment>(assignment);
                    list_dto_assignment.Add(dto_assignment);
                }
            }
            return list_dto_assignment;
        }

        #endregion

        #region CRUD methods

        public Pledge_Assignment Create_assignment(VM_Assignment_create vm_Assignment_create)
        {
            Pledge_Assignment assignment = new();

            Person_investor person_investor = _service_Person_investor.GetUserById(vm_Assignment_create.Person_ID);
            if (person_investor != null)
            {
                assignment.Person_investor = person_investor;

                _chempedb_context.Assignment.Add(assignment);
                _chempedb_context.SaveChanges();
            }
            return assignment;
        }

        public void Create_assignment(DTO_Pledge_Assignment dto_assignment)
        {
            if (dto_assignment != null)
            {
                Pledge_Assignment assignment = Utls.mapper.Map<Pledge_Assignment>(dto_assignment);
                _chempedb_context.Assignment.Add(assignment);
                _chempedb_context.SaveChanges();
            }
        }

        public void Update_assignment(DTO_Pledge_Assignment dto_Assignment)
        {
            if (dto_Assignment != null)
            {
                Pledge_Assignment assignment = Utls.mapper.Map<Pledge_Assignment>(dto_Assignment);
                if (assignment != null)
                {
                    _chempedb_context.Assignment.Update(assignment);
                    _chempedb_context.SaveChanges();
                }
            }
        }

        public void Delete_assignment(int id)
        {
            if (id > 0)
            {
                DTO_Pledge_Assignment dto_Assignment = Get_DTOAssignmentByID(id);
                if (dto_Assignment != null)
                {
                    Pledge_Assignment assignment = Utls.mapper.Map<Pledge_Assignment>(dto_Assignment);
                    if (assignment != null)
                    {
                        _chempedb_context.Assignment.Remove(assignment);
                        _chempedb_context.SaveChanges();
                    }
                }
            }
        }

        #endregion

    }
}