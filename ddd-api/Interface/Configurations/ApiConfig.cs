﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Interface.Configurations
{
    public static class ApiConfig
    {
        public static IServiceCollection WebApiConfig(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(Startup));

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
                        .AllowAnyHeader()
                        .AllowAnyHeader());

                //options.AddPolicy("Production",
                //    builder => builder
                //        .AllowAnyMethod()
                //        .AllowAnyOrigin()
                //        .AllowAnyHeader()
                //        .AllowAnyHeader());

                options.AddPolicy("Production",
                    builder => builder
                        .WithMethods("GET", "POST", "PUT", "DELETE", "OPTIONS")
                        .WithOrigins("https://meusistema.com.br", "https://meuoutrosistema.com.br")
                        .AllowAnyHeader());
            });

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            services.AddSwaggerConfig();

            services.AddJwtBearerConfig(configuration);

            //services.AddLoggingConfig();


            return services;
        }

        public static IApplicationBuilder UseMvcConfiguration(this IApplicationBuilder app, 
            IApiVersionDescriptionProvider provider, 
            IConfiguration configuration)
        {

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwaggerConfig(provider);

            //app.UseLoggingConfiguration(configuration);

            return app;
        }
    }
}
