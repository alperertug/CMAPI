using CMA.Application.Repositories.RepoTable;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoTable
{
    public class TableReadRepository : ReadRepository<Table>, ITableReadRepository
    {
        public TableReadRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
