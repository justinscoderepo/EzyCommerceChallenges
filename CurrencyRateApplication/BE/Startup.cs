using CurrencyRates.IProviders;
using CurrencyRates.IServices;
using CurrencyRates.Providers;
using CurrencyRates.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
namespace BE
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
            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Currency Rate Backend",
                    Description = "Currency Rate backend api",
                    Contact = new OpenApiContact
                    {
                        Name = "Justine Jose",
                        Email = "justnshalom@gmail.com"
                    },
                });
            });
            /**------Dependency Injection--------**/
            /// Providers
            services.AddScoped<ICurrencyXMLProvider, CurrencyXMLProvider>();
            /// Services
            services.AddScoped<ICurrencyRateService, CurrencyRateService>();
            services.AddScoped<ICurrencyCodeService, CurrencyCodeService>();
            /**------Dependency Injection ends--------**/
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                        {
                            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                            options.RoutePrefix = string.Empty;
                        });
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(x => x
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(_ => true) // allow any origin
               .AllowCredentials());
            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
