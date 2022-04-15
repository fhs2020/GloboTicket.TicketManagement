using AutoMapper;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

namespace GloboTicket.TicketManagement.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServiceRegistration(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
