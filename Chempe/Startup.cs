using Domain.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Chempe;

namespace Chempe
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();

            services.AddTransient<Service_Logs>();
            services.AddTransient<Service_Acceptance>();
            services.AddTransient<Service_Approval>();
            services.AddTransient<Service_Assignment>();
            services.AddTransient<Service_Document>();
            services.AddTransient<Service_Global_variables>();
            services.AddTransient<Service_Logs>();
            services.AddTransient<Service_Person>();
            services.AddTransient<Service_Photo>();
            services.AddTransient<Service_Pledge>();
            services.AddTransient<Service_Pledge_state>();
            services.AddTransient<Service_Request>();
            services.AddTransient<Service_User_client>();
            services.AddTransient<Service_User_chempe>();
            services.AddTransient<Service_User_investor>();
            services.AddTransient<Service_Warrant>();

            bool contextIsLocal = false;
            if (!bool.TryParse(_configuration.GetConnectionString("ConnectionString_isLocal"), out contextIsLocal))
            {
                contextIsLocal = false;
            }

            if (contextIsLocal)
            {
                services.AddDbContext<Chempedb_context>(e => e.UseSqlServer(_configuration.GetConnectionString("ConnectionString_chempedb")));
            }
            else
            {
                services.AddDbContext<Chempedb_context>(e => e.UseSqlServer(_configuration.GetConnectionString("ConnectionString_chempedb_remote")));
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            if (_environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var chempedb_context = serviceScope.ServiceProvider.GetRequiredService<Chempedb_context>();
                var configuration = serviceScope.ServiceProvider.GetRequiredService<IConfiguration>();
                new DB_initializer(chempedb_context, configuration).Initialize_data();
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
        //pattern: "{controller=Home}/{action=Index}/{id?}");
        //pattern: "{controller=User_client}/{action=Dashboard}/{id?}");
        //pattern: "{controller=User_client}/{action=New_client}/{id?}");
        //pattern: "{controller=User_client}/{action=New_request}/{id?}");
        pattern: "{controller=User_client}/{action=client_validation}/{id?}"); // Pasar CI (param), levantar usuario y cargarle la CI (foto)

                //endpoints.MapControllerRoute(
                //   name: "GMaps_inicio",
                //   pattern: "{controller=Dashboard}/{action=GMaps_inicio}/{id?}");

            });

            app.UseExceptionHandler("/page_404");
            //return System.Threading.Tasks.Task.CompletedTask;

        }
    }
}
