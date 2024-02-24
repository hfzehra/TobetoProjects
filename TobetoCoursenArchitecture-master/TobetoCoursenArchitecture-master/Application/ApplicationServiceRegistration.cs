using Application.Features.Categories.Profiles;
using Application.Features.Categories.Rules;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ApplicationServiceRegistration  
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(mapperConfig => {
                mapperConfig.AddProfile<MappingProfiles>();
            });

            services.AddSingleton(mapperConfiguration.CreateMapper());

            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            services.AddScoped<CategoryBusinessRules>();
            return services;
        }
    }
}
