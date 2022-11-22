using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using Services.ViewModels;
using System;

namespace Services.Chempe
{
    public class Service_Warrant_TV
    {
        private readonly IConfiguration _configuration;
        private readonly Chempedb_context _chempedb_context;
        private readonly Service_List_TV_brands _service_List_TV_brands;
        private readonly Service_List_TV_brand_models _service_List_TV_brand_models;
        private readonly Service_List_TV_technologies _service_List_TV_technologies;


        Configurations _configurations = new();

        public Service_Warrant_TV(Chempedb_context chempedb_context, IConfiguration configuration, Service_List_TV_brands service_List_TV_brands, 
            Service_List_TV_brand_models service_List_TV_brand_models, Service_List_TV_technologies service_List_TV_technologies)
        {
            _configuration = configuration;
            _chempedb_context = chempedb_context;
            _service_List_TV_brands = service_List_TV_brands;
            _service_List_TV_brand_models = service_List_TV_brand_models;
            _service_List_TV_technologies = service_List_TV_technologies;
        }


        public Warrant_TV Create_warrant_TV(VM_Request_create vm_Request_create)
        {
            Warrant_TV warrant_tv = new();
            warrant_tv.Inches = vm_Request_create.Inches;
            warrant_tv.IsSmart = vm_Request_create.IsSmart;


            warrant_tv.TV_Brand = _service_List_TV_brands.GetBrandByID(vm_Request_create.Brand_ID);
            warrant_tv.TV_brand_model = _service_List_TV_brand_models.GetModelByID(vm_Request_create.Model_ID);
            warrant_tv.TV_technology = _service_List_TV_technologies.GetTechnologyByID(vm_Request_create.Technology_ID);


            _chempedb_context.Warrant_TV.Add(warrant_tv);
            _chempedb_context.SaveChanges();

            return warrant_tv;
        }
    }
}
