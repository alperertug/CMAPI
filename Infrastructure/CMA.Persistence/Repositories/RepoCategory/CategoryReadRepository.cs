using CMA.Application.Repositories.RepoCategory;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoCategory
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
