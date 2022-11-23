using Domain.Context;
using Microsoft.Extensions.Configuration;

namespace Services.Chempe
{
    public class Service_Pledge_status
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        /* ------------ STATIC ENTITIES ------------ */

        public Service_Pledge_status(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }
    }
}
