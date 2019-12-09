using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Udemy.Dating.Application.Interfaces;

namespace Udemy.Dating.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration, string assemblyName)
        {
            services.AddDbContext<IDatingContext, DatingContext>(x => x.UseSqlite(
                configuration.GetConnectionString("DefaultConnection"), 
                x => x.MigrationsAssembly(assemblyName)
            ));
            return services;
        }
    }
}
