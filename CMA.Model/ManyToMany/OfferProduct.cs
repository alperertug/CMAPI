using CMA.Model.Abstract;

namespace CMA.Model.ManyToMany
{
    public class OfferProduct : ManyBase
    {
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
