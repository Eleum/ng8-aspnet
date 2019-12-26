using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using Udemy.Dating.Application.Commands;
using Udemy.Dating.Application.Interfaces;
using Udemy.Dating.Application.PipelineBehaviours;
using Udemy.Dating.Application.Repositories;
using Udemy.Dating.Application.Repositories.Cached;

namespace Udemy.Dating.Application
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IValuesRepository, ValuesRepository>();
            services.Decorate<IValuesRepository, CachedValuesRepository>();

            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            
            return services;
        }
    }
}
