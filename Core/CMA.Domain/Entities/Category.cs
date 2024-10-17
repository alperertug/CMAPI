using CMA.Domain.Entities.Common;

namespace CMA.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public Cafe Cafe { get; set; }
        ICollection<Product>? Products { get; set; }
    }
}
