using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Dating.Api.Options;
using Udemy.Dating.Application;

namespace Udemy.Dating.Api.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = new JwtSettings();
            configuration.Bind(nameof(jwtSettings), jwtSettings);
            services.AddSingleton(jwtSettings);

            services.AddControllers();
            services.AddApplicationServices();
            services.AddCors(options =>
            {
                options.AddPolicy(configuration.GetValue<string>("CorsPolicy"),
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200", "https://localhost:4200");
                    });
            });
        }
    }
}
