using CMA.Application.Abstractions;
using CMA.Persistence.Concretes;
using CMA.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace CMA.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CafeManagementAPIDbContext>(options => options.Use);
        }
    }
}
