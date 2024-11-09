using CMA.Application.Repositories.RepoCafeUser;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoCafeUser
{
    public class CafeUserReadRepository : ReadRepository<CafeUser>, ICafeUserReadRepository
    {
        public CafeUserReadRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
