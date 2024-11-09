using CMA.Application.Repositories.RepoProduct;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoProduct
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
