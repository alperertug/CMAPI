using CMA.Domain.Entities.Common;

namespace CMA.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string? CustomerMessage { get; set; }
        public DateTime OrderTime { get; set; }
        public bool isCancelled { get; set; } = false;
        public bool isDone { get; set; } = false;
        public Table Table { get; set; }
        public Cafe Cafe { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
