using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.ViewModels;
using System;

namespace Services.Chempe
{
    public class Service_Pledge
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Logs _service_logs;
        private readonly Service_Global_variables _service_global_variables;
        private readonly Service_Pledge_Request _service_request;
        private readonly Service_Person _service_person;
        private readonly Service_Warrant _service_warrant;
        private readonly Service_Warrant_TV _service_warrant_TV;

        /* ------------ STATIC ENTITIES ------------ */
        private readonly Service_List_warrants_type _service_List_warrants_type;


        public Service_Pledge(Chempedb_context chempedb_context, IConfiguration configuration, Service_Logs service_logs, Service_Global_variables service_global_variables,
            Service_Pledge_Request service_request, Service_Person service_person, Service_Warrant service_Warrant, Service_Warrant_TV service_Warrant_TV, Service_List_warrants_type service_List_warrants_type)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;

            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_request = service_request;
            _service_person = service_person;
            _service_warrant = service_Warrant;
            _service_warrant_TV = service_Warrant_TV;
            _service_List_warrants_type = service_List_warrants_type;

        }

        /// <summary>
        /// ToDo: Cargar los DDL seleccionados, bah todos los campos.
        /// Función onChange en DDL.
        /// </summary>
        /// <param name="vm_Request_create"></param>
        public void Create_Pledge(VM_Request_create vm_Request_create)
        {
            string Warrant_type_str = (string)vm_Request_create.Warrant_type_ID;
            int Warrant_type_ID = 0;
            if (!int.TryParse(Warrant_type_str, out Warrant_type_ID))
            {
                Warrant_type_ID = 0;
            }
            Warrant warrant = null;

            string Warrant_type_name = _service_List_warrants_type.GetWarrantTypeByID(Warrant_type_ID);
            if (!string.IsNullOrWhiteSpace(Warrant_type_name))
            {
                switch (Warrant_type_name)
                {
                    case nameof(Service_Global_variables.Warrants_type_enum.Televisor):
                        {
                            warrant = (Warrant_TV)_service_warrant_TV.Create_warrant_TV(vm_Request_create);
                            break;
                        }
                }
            }

            Pledge_Request request = _service_request.Create_request(vm_Request_create);
            if (request != null)
            {
                Pledge pledge = new();
                pledge.Warrant = warrant;
                pledge.Request = request;

                _chempedb_context.Pledge.Add(pledge);
                _chempedb_context.SaveChanges();
            }
        }

    }
}