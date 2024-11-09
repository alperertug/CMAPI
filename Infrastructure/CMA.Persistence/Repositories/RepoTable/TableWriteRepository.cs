using CMA.Application.Repositories.RepoTable;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoTable
{
    public class TableWriteRepository : WriteRepository<Table>, ITableWriteRepository
    {
        public TableWriteRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
