using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
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

        public void Create_warrant_TV(DTO_Warrant_TV dto_Warrant_tv)
        {
            if (dto_Warrant_tv != null)
            {
                Warrant_TV request = Utls.mapper.Map<Warrant_TV>(dto_Warrant_tv);
                _chempedb_context.Warrant_TV.Add(request);
                _chempedb_context.SaveChanges();
            }
        }

        public void Create_warrant_TV(DTO_Request_create dto_Request_create)
        {
            Warrant_TV warrant_tv = new();
            warrant_tv.Inches = dto_Request_create.Inches;
            warrant_tv.IsSmart = dto_Request_create.IsSmart;


            warrant_tv.TV_Brand = _service_List_TV_brands.GetBrandByID(dto_Request_create.Brand);
            warrant_tv.TV_brand_model = _service_List_TV_brand_models.GetModelByID(dto_Request_create.Model);
            warrant_tv.TV_technology = _service_List_TV_technologies.GetTechnologyByID(dto_Request_create.Technology);



        }
    }
}
