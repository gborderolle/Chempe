using Domain.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Chempe;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

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

            /* ------------ STATIC ENTITIES ------------ */
            services.AddTransient<Service_List_TV_brands>();
            services.AddTransient<Service_List_TV_brand_models>();
            services.AddTransient<Service_List_TV_technologies>();
            services.AddTransient<Service_List_warrants_type>();


            /* ------------ DYNAMIC ENTITIES ------------ */
            services.AddTransient<Service_Acceptance>();
            services.AddTransient<Service_Approval>();
            services.AddTransient<Service_Assignment>();
            services.AddTransient<Service_Document>();
            services.AddTransient<Service_Global_variables>();
            services.AddTransient<Service_Logs>();
            services.AddTransient<Service_Person>();
            services.AddTransient<Service_Photo>();
            services.AddTransient<Service_Pledge>();
            services.AddTransient<Service_Pledge_status>();
            services.AddTransient<Service_Request>();
            services.AddTransient<Service_User_client>();
            services.AddTransient<Service_User_chempe>();
            services.AddTransient<Service_User_investor>();
            services.AddTransient<Service_Warrant>();
            services.AddTransient<Service_Warrant_TV>();
            services.AddTransient<Service_Session>();


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

            services.AddSession(Options =>
            {
                Options.IdleTimeout = TimeSpan.FromSeconds(3600);
                Options.Cookie.HttpOnly = true;
                Options.Cookie.IsEssential = true;
            });
            services.AddMvc();

            #region Authorization definitions

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(options =>
            {
                options.LoginPath = "/login";
                options.AccessDeniedPath = "/denied";
                options.Events = new CookieAuthenticationEvents()
                {
                    OnSigningIn = async context =>
                    {
                        var scheme = context.Properties.Items.Where(k => k.Key == ".AuthScheme").FirstOrDefault();
                        var claim = new Claim(scheme.Key, scheme.Value);
                        var claimsIdentity = context.Principal.Identity as ClaimsIdentity;
                        if (1 == 1)
                        {
                            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
                        }
                        else
                        {
                            var user_service = context.HttpContext.RequestServices.GetRequiredService(typeof(Service_User_client)) as Service_User_client; // ToDo, cuidado con todos los tipos de usuario. Hacer de Person mejor?
                            var nameIdentifier = claimsIdentity.Claims.FirstOrDefault(m => m.Type == ClaimTypes.NameIdentifier)?.Value;
                            if (user_service != null && nameIdentifier != null)
                            {
                                var appUser = user_service.GetUserByExternalProvider(scheme.Value, nameIdentifier);
                                if (appUser is null)
                                {
                                    appUser = user_service.AddNewUser(scheme.Value, claimsIdentity.Claims.ToList());
                                }
                                /*foreach (var r in appUser.RoleList)
                                {
                                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, r));
                                }*/
                            }
                            claimsIdentity.AddClaim(claim);
                        }
                        await Task.CompletedTask;
                    }
                };

            });

            #endregion
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
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
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

        //pattern: "{controller}/{action}/{identification}", new { controller = "User_client", action = "client_validation", identification = "42305298" });
        
        pattern: "{controller}/{action}/{identification}", new { controller = "Login_page", action = "Login", identification = "42305298" });


        });

            app.UseExceptionHandler("/page_404");
            //return System.Threading.Tasks.Task.CompletedTask;

        }
    }
}
