using CMA.Domain.Entities.Common;

namespace CMA.Domain.Entities
{
    public class Table : BaseEntity
    {
        public string TableName { get; set; }
        public string QrCode { get; set; }
        public bool isEmpty { get; set; } = true;
        public int PositionIndex { get; set; }
        public Cafe Cafe { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
