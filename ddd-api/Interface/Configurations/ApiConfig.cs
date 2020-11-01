using Interface.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface.Configurations
{
    public static class ApiConfig
    {
        public static IServiceCollection WebApiConfig(this IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });


            services.AddCors(options =>
            {
                options.AddPolicy("Development",
                    builder => builder
                        .AllowAnyMethod()
                        .AllowAnyOrigin()
                        .AllowAnyHeader());

                options.AddPolicy("Production",
                    builder => builder
                        .WithMethods("GET", "POST", "PUT", "DELETE", "OPTIONS")
                        .WithOrigins("https://meusistema.com.br", "https://meuoutrosistema.com.br")
                        .AllowAnyHeader());

            });

            services.AddSwaggerConfig();


            return services;
        }

        public static IApplicationBuilder UseMvcConfiguration(this IApplicationBuilder app, IApiVersionDescriptionProvider provider)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwaggerConfig(provider);

            app.UseMiddleware<ExceptionMiddleware>();

            return app;
        }
    }
}
