using CMA.Application.Repositories.RepoOffer;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoOffer
{
    public class OfferReadRepository : ReadRepository<Offer>, IOfferReadRepository
    {
        public OfferReadRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
