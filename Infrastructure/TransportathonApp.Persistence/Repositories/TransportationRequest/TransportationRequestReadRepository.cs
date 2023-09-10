using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class TransportationRequestReadRepository : ReadRepository<TransportationRequest>, ITransportationRequestReadRepository
{
    public TransportationRequestReadRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
