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
        private readonly Service_Request _service_request;
        private readonly Service_Person _service_person;
        private readonly Service_Warrant _service_warrant;
        private readonly Service_Warrant_TV _service_warrant_TV;
        private readonly Service_Pledge _service_pledge;


        Configurations _configurations = new();

        public Service_Pledge(Chempedb_context chempedb_context, IConfiguration configuration, Service_Logs service_logs, Service_Global_variables service_global_variables,
            Service_Request service_request, Service_Person service_person, Service_Warrant service_Warrant, Service_Warrant_TV service_Warrant_TV, Service_Pledge service_pledge)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;

            _service_logs = service_logs;
            _service_global_variables = service_global_variables;
            _service_request = service_request;
            _service_person = service_person;
            _service_warrant = service_Warrant;
            _service_warrant_TV = service_Warrant_TV;
            _service_pledge = service_pledge;

        }

        public void Create_Pledge(VM_Request_create vm_Request_create)
        {
            //vm_Request_create.Warrant_type

            Warrant_TV warrant_TV = _service_warrant_TV.Create_warrant_TV(vm_Request_create);
            //Warrant warrant = _service_warrant.Create_warrant(vm_Request_create);
            Request request = _service_request.Create_request(vm_Request_create);


            Pledge pledge = new();
            pledge.Warrant = warrant_TV;
            pledge.Request = request;

            _chempedb_context.Pledge.Add(pledge);
            _chempedb_context.SaveChanges();

        }
    }
}
