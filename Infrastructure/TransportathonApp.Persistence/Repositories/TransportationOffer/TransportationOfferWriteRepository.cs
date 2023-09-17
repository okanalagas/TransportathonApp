using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;

public class TransportationOfferWriteRepository : WriteRepository<TransportationOffer>, ITransportationOfferWriteRepository
{
    public TransportationOfferWriteRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
