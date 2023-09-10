using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class DriverReadRepository : ReadRepository<Driver>, IDriverReadRepository
{
    public DriverReadRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
