using CMA.Domain.Entities;

namespace CMA.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
