using CMA.Model.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMA.Model
{
    public class Table : ModelBase
    {
        public string TableName { get; set; }
        public string QrCode { get; set; }
        public bool isEmpty { get; set; } = true;
        public int Location { get; set; }
        public int? CafeId { get; set; }
        [ForeignKey("CafeId")]
        public Cafe? Cafe { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
