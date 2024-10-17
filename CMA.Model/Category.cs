using CMA.Model.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMA.Model
{
    public class Category : ModelBase
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public int? CafeId { get; set; }
        [ForeignKey("CafeId")]
        public Cafe? Cafe { get; set; }
        ICollection<Product>? Products { get; set; }
    }
}
