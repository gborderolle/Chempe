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

        /* ------------ DYNAMIC ENTITIES ------------ */
        //private readonly Service_Pledge _service_pledge;

        /* ------------ STATIC ENTITIES ------------ */
        private readonly Service_List_TV_brands _service_List_TV_brands;
        private readonly Service_List_TV_brand_models _service_List_TV_brand_models;
        private readonly Service_List_TV_technologies _service_List_TV_technologies;
        private readonly Service_List_warrants_type _service_List_warrants_type;


        public Service_Warrant_TV(Chempedb_context chempedb_context, IConfiguration configuration, /*Service_Pledge service_pledge,*/
            Service_List_TV_brands service_List_TV_brands, Service_List_TV_brand_models service_List_TV_brand_models, Service_List_TV_technologies service_List_TV_technologies, Service_List_warrants_type service_List_warrants_type)
        {
            _configuration = configuration;
            _chempedb_context = chempedb_context;
            //_service_pledge = service_pledge;

            _service_List_TV_brands = service_List_TV_brands;
            _service_List_TV_brand_models = service_List_TV_brand_models;
            _service_List_TV_technologies = service_List_TV_technologies;
            _service_List_warrants_type = service_List_warrants_type;
        }

        public Warrant_TV Create_warrant_TV(VM_Request_create vm_Request_create, Pledge pledge)
        {
            string Inches_str = (string)vm_Request_create.Inches;
            int Inches = 0;
            if(!int.TryParse(Inches_str,out Inches)){
                Inches = 0;
            }

            string IsSmart_str = (string)vm_Request_create.IsSmart;
            bool IsSmart = false;
            if (!bool.TryParse(Inches_str, out IsSmart))
            {
                IsSmart = false;
            }

            string Brand_ID_str = (string)vm_Request_create.Brand_ID;
            int Brand_ID = 0;
            if (!int.TryParse(Brand_ID_str, out Brand_ID))
            {
                Brand_ID = 0;
            }

            string Model_ID_str = (string)vm_Request_create.Model_ID;
            int Model_ID = 0;
            if (!int.TryParse(Model_ID_str, out Model_ID))
            {
                Model_ID = 0;
            }

            string Technology_ID_str = (string)vm_Request_create.Technology_ID;
            int Technology_ID = 0;
            if (!int.TryParse(Technology_ID_str, out Technology_ID))
            {
                Technology_ID = 0;
            }

            string Warrant_type_ID_str = (string)vm_Request_create.Warrant_type_ID;
            int Warrant_type_ID = 0;
            if (!int.TryParse(Warrant_type_ID_str, out Warrant_type_ID))
            {
                Warrant_type_ID = 0;
            }

            Warrant_TV warrant_tv = new();
            warrant_tv.Inches = Inches;
            warrant_tv.IsSmart = IsSmart;
            warrant_tv.TV_Brand = _service_List_TV_brands.GetBrandByID(Brand_ID);
            warrant_tv.TV_brand_model = _service_List_TV_brand_models.GetModelByID(Model_ID);
            warrant_tv.TV_technology = _service_List_TV_technologies.GetTechnologyByID(Technology_ID);
            warrant_tv.Warrant_type = _service_List_warrants_type.GetWarrantTypeByID(Warrant_type_ID);

            warrant_tv.Pledge = pledge;

            _chempedb_context.Warrant_TV.Add(warrant_tv);
            _chempedb_context.SaveChanges();

            return warrant_tv;
        }
    }
}
