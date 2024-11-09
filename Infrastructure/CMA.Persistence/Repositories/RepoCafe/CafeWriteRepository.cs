using CMA.Application.Repositories.RepoCafe;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoCafe
{
    public class CafeWriteRepository : WriteRepository<Cafe>, ICafeWriteRepository
    {
        public CafeWriteRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
