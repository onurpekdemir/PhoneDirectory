using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PD.Service.Contact.Profiles;
using PD.Service.Contact.Repositories;
using PD.Service.Contact.Services;
using PD.Service.Contact.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Extensions
{
    public static class ServiceRegisterationExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IContactInfoRepository, ContactInfoRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }    
        
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ContactProfile());
                mc.AddProfile(new ContactInfoProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IContactInfoService, ContactInfoService>();
            return services;
        }
    }
}
