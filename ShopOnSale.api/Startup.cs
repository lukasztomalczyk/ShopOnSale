using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopOnSale.api.Map;
using ShopOnSale.services.Context;
using ShopOnSale.services.Interface;
using ShopOnSale.services.Repository;
using ShopOnSale.services.Services;

namespace ShopOnSale.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ApplicationDbContext>(option => option.UseInMemoryDatabase("myDB"));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IShopServices, ShopServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes => 
                routes.MapRoute(
                    name: "Errors",
                    template: "{*url}",
                    defaults: new { controller = "Errors", action = "Error404"}));
            app.UseSwaggerUi();
            
            MapperAuto.InitialConfigure();
        }
    }
}
