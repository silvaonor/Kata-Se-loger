using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace RealEstateRelationship.Application.Persistence.Service
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
