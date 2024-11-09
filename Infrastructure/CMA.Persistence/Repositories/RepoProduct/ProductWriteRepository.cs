using CMA.Application.Repositories.RepoProduct;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoProduct
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
