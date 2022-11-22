using Domain.Context;
using Microsoft.Extensions.Configuration;

namespace Services.Chempe
{
    public class Service_Person_user
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        Configurations _configurations = new();

        public Service_Person_user(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

    }
}
