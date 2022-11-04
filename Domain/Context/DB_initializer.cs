using Microsoft.Extensions.Configuration;

namespace Domain.Context
{
    public class DB_initializer
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;
        private bool ContextIsLocal = false;

        public DB_initializer(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;

            if (!bool.TryParse(_configuration.GetConnectionString("ConnectionString_isLocal"), out ContextIsLocal))
            {
                ContextIsLocal = false;
            }
        }
        public void Initialize_data()
        {

        }

    }
}
