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
    public class Service_List_TV_technologies
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        Configurations _configurations = new();

        public Service_List_TV_technologies(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

        public List<DTO_List_TV_technologies> Get_DTO_List_TV_technologies()
        {
            List<DTO_List_TV_technologies> List_DTO_List_TV_technologies = new();
            List<List_TV_technologies> List_TV_technologies1 = _chempedb_context.List_TV_technologies.ToList(); // Include() ??
            foreach (List_TV_technologies _List_TV_technologies in List_TV_technologies1)
            {
                List_DTO_List_TV_technologies.Add(Utls.mapper.Map<DTO_List_TV_technologies>(_List_TV_technologies));
            }
            return List_DTO_List_TV_technologies;
        }

        internal List_TV_technologies GetTechnologyByID(string technology)
        {
            throw new NotImplementedException();
        }
    }
}