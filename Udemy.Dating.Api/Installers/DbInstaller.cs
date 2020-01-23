using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Udemy.Dating.Persistence;

namespace Udemy.Dating.Api.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistenceServices(configuration, Assembly.GetExecutingAssembly().FullName);
        }
    }
}
