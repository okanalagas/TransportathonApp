using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;

public class TransportationOfferReadRepository : ReadRepository<TransportationOffer>, ITransportationOfferReadRepository
{
    public TransportationOfferReadRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
