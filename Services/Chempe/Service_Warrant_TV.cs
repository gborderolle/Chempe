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
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        Configurations _configurations = new();

        public Service_Warrant_TV(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
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
    }
}
