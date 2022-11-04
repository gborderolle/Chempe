using Domain.Context;
using Microsoft.Extensions.Configuration;

namespace Services.Chempe
{
    public class Service_User_Client
    {
        private readonly Chempedb_context _chevacaDB_context;
        private readonly IConfiguration _configuration;

        Configurations _configurations = new();

        public Service_User_Client(Chempedb_context chevacaDB_context, IConfiguration configuration)
        {
            _chevacaDB_context = chevacaDB_context;
            _configuration = configuration;
        }
    }
}

