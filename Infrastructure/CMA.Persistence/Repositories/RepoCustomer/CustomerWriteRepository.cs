using CMA.Application.Repositories.RepoCustomer;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoCustomer
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
