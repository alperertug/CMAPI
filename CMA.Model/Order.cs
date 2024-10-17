using CMA.Model.Abstract;
using CMA.Model.ManyToMany;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMA.Model
{
    public class Order : ModelBase
    {
        public string? CustomerMessage { get; set; }
        public DateTime OrderTime { get; set; }
        public bool isCancelled { get; set; }
        public bool isDone { get; set; }
        public int? TableId { get; set; }
        [ForeignKey("TableId")]
        public Table? Table { get; set; }
        public int? CafeId { get; set; }
        [ForeignKey("CafeId")]
        public Cafe? Cafe { get; set; }
        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
