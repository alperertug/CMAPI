using CMA.Application.Repositories.RepoOrder;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoOrder
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
