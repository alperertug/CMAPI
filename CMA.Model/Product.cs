using CMA.Model.Abstract;
using CMA.Model.ManyToMany;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMA.Model
{
    public class Product : ModelBase
    {
        public string Name { get; set; }
        public string? Ingredients { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public bool Availability { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public int? CafeId { get; set; }
        [ForeignKey("CafeId")]
        public Cafe? Cafe { get; set; }
        public ICollection<OfferProduct>? OfferProducts { get; set; }
        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
