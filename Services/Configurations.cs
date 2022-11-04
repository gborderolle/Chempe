using Microsoft.Extensions.Configuration;
using System.IO;

namespace Services
{
    public class Configurations
    {
        public string API_link { get; set; }
        public string API_token { get; set; }
        public string Usuario_logueado { get; set; }
        public string ConnectionString_chempedb { get; set; }
        public string ConnectionString_chempedb_remoto { get; set; }
        public string ConnectionString_isLocal { get; set; }
        public string Error_log_file { get; set; }
        public string GetKey { get; set; }

        public Configurations()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"), optional: false)
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.Development.json"), optional: false)
                .Build();

            ConnectionString_chempedb = configuration.GetConnectionString("ConnectionString_chempedb");
            ConnectionString_chempedb_remoto = configuration.GetConnectionString("ConnectionString_chempedb_remoto");
            ConnectionString_isLocal = configuration.GetConnectionString("ConnectionString_isLocal");
            Error_log_file = configuration.GetSection("Error_log_file").Value;
        }

    }
}