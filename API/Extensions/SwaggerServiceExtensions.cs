using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            //<PackageReference Include="Swashbuckle.AspNetCore.SwaggerGen" Version="5.6.1"/>
            //<PackageReference Include="Swashbuckle.AspNetCore.SwaggerUI" Version="5.6.1"/>
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo {Title = "SkiNet API", Version = "v1"});
            });

            return services;
        }


        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
                        // Swashbuckle.AspNetCore.SwaggerGen
            app.UseSwagger();
            
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "SkiNet API v1"); });  

            return app;
        }
    }
}