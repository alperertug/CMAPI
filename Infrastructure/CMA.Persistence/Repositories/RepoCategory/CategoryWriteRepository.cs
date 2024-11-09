using CMA.Application.Repositories.RepoCategory;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoCategory
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
