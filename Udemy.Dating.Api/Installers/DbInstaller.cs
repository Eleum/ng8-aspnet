using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Udemy.Dating.Persistence;

namespace Udemy.Dating.Api.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistenceServices(configuration, Assembly.GetExecutingAssembly().FullName);
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<DatingContext>();
        }
    }
}
