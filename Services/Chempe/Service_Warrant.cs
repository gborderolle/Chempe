using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using Services.ViewModels;
using System;

namespace Services.Chempe
{
    public class Service_Warrant
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        Configurations _configurations = new();

        public Service_Warrant(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

        public void Create_warrant(DTO_Warrant dto_Warrant)
        {
            if (dto_Warrant != null)
            {
                Warrant request = Utls.mapper.Map<Warrant>(dto_Warrant);
                _chempedb_context.Warrant.Add(request);
                _chempedb_context.SaveChanges();
            }
        }

        public void Create_warrant(VM_Request_create vm_Request_create)
        {
            throw new NotImplementedException();
        }
    }
}
