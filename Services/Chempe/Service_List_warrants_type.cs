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
    public class Service_List_warrants_type
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        /* ------------ STATIC ENTITIES ------------ */


        public Service_List_warrants_type(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

        public List<DTO_List_warrants_type> Get_DTO_List_warrants_type()
        {
            List<DTO_List_warrants_type> List_DTO_List_warrants_type = new();
            List<List_warrants_type> List_warrants_type1 = _chempedb_context.List_warrants_type.ToList(); // Include() ??
            foreach (List_warrants_type _List_warrants_type in List_warrants_type1)
            {
                List_DTO_List_warrants_type.Add(Utls.mapper.Map<DTO_List_warrants_type>(_List_warrants_type));
            }
            return List_DTO_List_warrants_type;
        }

        internal string GetWarrantTypeNameByID(int warrant_type_ID)
        {
            string result = string.Empty;
            if (warrant_type_ID > 0)
            {
                List_warrants_type list_warrants_type = _chempedb_context.List_warrants_type.Find(warrant_type_ID);
                if (list_warrants_type != null)
                {
                    result = list_warrants_type.Name;
                }
            }
            return result;
        }

        internal List_warrants_type GetWarrantTypeByID(int warrant_type_ID)
        {
            List_warrants_type result = null;
            if (warrant_type_ID > 0)
            {
                result = _chempedb_context.List_warrants_type.Find(warrant_type_ID);
            }
            return result;
        }

    }
}
