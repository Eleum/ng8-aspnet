using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Udemy.Dating.Application.Interfaces;

namespace Udemy.Dating.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration, string assemblyName)
        {
            services.AddDbContext<DatingContext>(options => 
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"), 
                x => x.MigrationsAssembly(assemblyName)
            ));
            services.AddScoped<IDatingContext, DatingContext>();

            return services;
        }
    }
}
