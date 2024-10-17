using CMA.Model.Abstract;

namespace CMA.Model.ManyToMany
{
    public class CafeCustomer : ManyBase
    {
        public int CafeId { get; set; }
        public Cafe Cafe { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
