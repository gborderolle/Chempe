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
    public class Service_List_TV_brands
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        /* ------------ STATIC ENTITIES ------------ */


        public Service_List_TV_brands(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

        public List<DTO_List_TV_brands> Get_DTO_List_TV_brands()
        {
            List<DTO_List_TV_brands> List_DTO_List_TV_brands = new();
            List<List_TV_brands> List_TV_brands1 = _chempedb_context.List_TV_brands.ToList(); // Include() ??
            foreach(List_TV_brands _List_TV_brands in List_TV_brands1)
            {
                List_DTO_List_TV_brands.Add(Utls.mapper.Map<DTO_List_TV_brands>(_List_TV_brands));
            }
            return List_DTO_List_TV_brands;
        }

        internal List_TV_brands GetBrandByID(int brand)
        {
            return _chempedb_context.List_TV_brands.FirstOrDefault(x => x.List_TV_brands_ID == brand);
        }

    }
}