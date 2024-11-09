using CMA.Application.Repositories.RepoCustomer;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoCustomer
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
