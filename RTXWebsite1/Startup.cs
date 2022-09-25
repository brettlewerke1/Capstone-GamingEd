
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Blazored.LocalStorage;
using RTXWebsite1.IDbContext;
using RTXWebsite1.DbContext;
using RTXWebsite1.Data;

namespace RTXWebsite1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazoredLocalStorage();   // local storage
            services.AddBlazoredLocalStorage(config =>
                config.JsonSerializerOptions.WriteIndented = true);  // local storage
            services.AddRazorPages();
            services.AddServerSideBlazor();
            // add services needed (IDb Contexts, and Db contexts)
            services.AddSingleton<IAccountAccess, AccountAccess>();
            services.AddSingleton<IDatabaseAccess, DatabaseAccess>();
            services.AddSingleton<IMarketplaceAccess, MarketplaceAccess>();

            services.AddSingleton<Cookies>();
            services.AddSingleton<Utils>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
