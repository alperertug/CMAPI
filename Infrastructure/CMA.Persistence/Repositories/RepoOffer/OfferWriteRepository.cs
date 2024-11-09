using CMA.Application.Repositories.RepoOffer;
using CMA.Domain.Entities;
using CMA.Persistence.Contexts;

namespace CMA.Persistence.Repositories.RepoOffer
{
    public class OfferWriteRepository : WriteRepository<Offer>, IOfferWriteRepository
    {
        public OfferWriteRepository(CafeManagementAPIDbContext context) : base(context)
        {
        }
    }
}
