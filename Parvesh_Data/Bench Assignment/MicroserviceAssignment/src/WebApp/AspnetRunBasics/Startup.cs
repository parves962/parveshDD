using AspnetRunBasics.ApiCollection;
using AspnetRunBasics.ApiCollection.Interfaces;
using AspnetRunBasics.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace AspnetRunBasics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ApiSettings>(Configuration.GetSection(nameof(ApiSettings)));
            services.AddSingleton<IApiSettings>(s => s.GetRequiredService<IOptions<ApiSettings>>().Value);

            services.AddHttpClient();

            services.AddTransient<ICatalogApi, CatalogApi>();
            services.AddTransient<IShopCartApi, ShopCartApi>();
            services.AddTransient<IOrderApi, OrderApi>();

            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
