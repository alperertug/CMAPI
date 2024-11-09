using CMA.Application.Repositories.RepoOrder;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoOrder
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
