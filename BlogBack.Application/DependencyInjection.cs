using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogBack.Application.AutoMapperProfile;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BlogBack.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            #region MediatR
            var assembly = typeof(DependencyInjection).Assembly;
            services.AddMediatR(configuration =>
                     configuration.RegisterServicesFromAssemblies(assembly));
            services.AddValidatorsFromAssembly(assembly);
            #endregion


            services.AddAutoMapper(typeof(DtoProfile));


            return services;
        }
    }
}
