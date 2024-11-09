using CMA.Application.Repositories.RepoCafeUser;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoCafeUser
{
    public class CafeUserWriteRepository : WriteRepository<CafeUser>, ICafeUserWriteRepository
    {
        public CafeUserWriteRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
