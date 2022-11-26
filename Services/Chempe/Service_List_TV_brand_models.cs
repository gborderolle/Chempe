using Domain.Chempe;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.JSMs;
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

        /* ------------ DYNAMIC ENTITIES ------------ */
        /* ------------ STATIC ENTITIES ------------ */


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

        internal List_TV_brand_models GetModelByID(int model)
        {
            return _chempedb_context.List_TV_brand_models.FirstOrDefault(x => x.List_TV_brand_models_ID == model);
        }

        public List<JSM_TV_brand_models> GetJSM_List_TV_brand_modelsByBrandID(string ddl_brand)
        {
            List<JSM_TV_brand_models> result = new();
            if (!string.IsNullOrWhiteSpace(ddl_brand))
            {
                int brand_ID = 0;
                if (!int.TryParse(ddl_brand, out brand_ID))
                {
                    brand_ID = 0;
                }
                if (brand_ID > 0)
                {
                    List_TV_brands List_TV_brands = _chempedb_context.List_TV_brands.Include("List_TV_brand_models").FirstOrDefault(e => e.List_TV_brands_ID == brand_ID);
                    if (List_TV_brands != null)
                    {
                        List<List_TV_brand_models> List_TV_brands1 = List_TV_brands.List_TV_brand_models;
                        foreach (List_TV_brand_models _List_TV_brands in List_TV_brands1)
                        {
                            result.Add(new JSM_TV_brand_models(_List_TV_brands.List_TV_brand_models_ID.ToString(), _List_TV_brands.Name, _List_TV_brands.Description));
                        }
                    }
                }
            }
            return result;
        }
    }
}