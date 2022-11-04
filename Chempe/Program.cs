using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Chempe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //webBuilder.UseUrls("https://0.0.0.0:5001/"); // Testing mobile on LAN

                });
    }
}
