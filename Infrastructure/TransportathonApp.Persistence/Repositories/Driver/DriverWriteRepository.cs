using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class DriverWriteRepository : WriteRepository<Driver>, IDriverWriteRepository
{
    public DriverWriteRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
