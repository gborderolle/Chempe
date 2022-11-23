using Domain.Context;
using Microsoft.Extensions.Configuration;

namespace Services.Chempe
{
    public class Service_Person_investor
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        /* ------------ STATIC ENTITIES ------------ */


        public Service_Person_investor(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }
    }
}

