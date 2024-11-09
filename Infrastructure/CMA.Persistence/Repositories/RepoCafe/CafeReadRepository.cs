using CMA.Application.Repositories.RepoCafe;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoCafe
{
    public class CafeReadRepository : ReadRepository<Cafe>, ICafeReadRepository
    {
        public CafeReadRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
