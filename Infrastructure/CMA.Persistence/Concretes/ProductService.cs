using CMA.Application.Abstractions;
using CMA.Domain.Entities;

namespace CMA.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new() { Id = Guid.NewGuid(), Name = "Kahve", Price = 75 },
                new() { Id = Guid.NewGuid(), Name = "Çay", Price = 30 },
                new() { Id = Guid.NewGuid(), Name = "Çorba", Price = 110 },
                new() { Id = Guid.NewGuid(), Name = "Tatar Böreği", Price = 135 },
                new() { Id = Guid.NewGuid(), Name = "İzmir Köfte", Price = 190 },
                new() { Id = Guid.NewGuid(), Name = "BigMac", Price = 205 },
            };
    }
}
