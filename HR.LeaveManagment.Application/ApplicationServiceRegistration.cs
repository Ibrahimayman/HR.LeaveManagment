using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using MediatR;

namespace HR.LeaveManagment.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services) {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
