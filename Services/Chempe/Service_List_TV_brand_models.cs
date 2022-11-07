using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Chempe
{
    public class Service_List_TV_brand_models
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        Configurations _configurations = new();

        public Service_List_TV_brand_models(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

        public List<DTO_List_TV_brand_models> Get_DTO_List_TV_brand_models()
        {
            List<DTO_List_TV_brand_models> List_DTO_List_TV_brand_models = new();
            List<List_TV_brand_models> List_TV_brands1 = _chempedb_context.List_TV_brand_models.ToList(); // Include() ??
            foreach (List_TV_brand_models _List_TV_brands in List_TV_brands1)
            {
                List_DTO_List_TV_brand_models.Add(Utls.mapper.Map<DTO_List_TV_brand_models>(_List_TV_brands));
            }
            return List_DTO_List_TV_brand_models;
        }
    }
}