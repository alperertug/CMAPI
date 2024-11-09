using Microsoft.EntityFrameworkCore;
using CMA.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using CMA.Application.Repositories.RepoCafe;
using CMA.Persistence.Repositories.RepoCustomer;
using CMA.Persistence.Repositories.RepoCafe;
using CMA.Application.Repositories.RepoCafeUser;
using CMA.Persistence.Repositories.RepoCafeUser;
using CMA.Application.Repositories.RepoCategory;
using CMA.Persistence.Repositories.RepoCategory;
using CMA.Application.Repositories.RepoCustomer;
using CMA.Application.Repositories.RepoOffer;
using CMA.Persistence.Repositories.RepoOffer;
using CMA.Application.Repositories.RepoOrder;
using CMA.Persistence.Repositories.RepoOrder;
using CMA.Application.Repositories.RepoProduct;
using CMA.Persistence.Repositories.RepoProduct;
using CMA.Application.Repositories.RepoTable;
using CMA.Persistence.Repositories.RepoTable;

namespace CMA.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CafeManagementAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICafeReadRepository, CafeReadRepository>();
            services.AddScoped<ICafeWriteRepository, CafeWriteRepository>();
            services.AddScoped<ICafeUserReadRepository, CafeUserReadRepository>();
            services.AddScoped<ICafeUserWriteRepository, CafeUserWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOfferReadRepository, OfferReadRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<ITableReadRepository, TableReadRepository>();
            services.AddScoped<ITableWriteRepository, TableWriteRepository>();
        }
    }
}
