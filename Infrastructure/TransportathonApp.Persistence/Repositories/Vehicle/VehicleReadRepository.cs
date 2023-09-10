using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;

public class VehicleReadRepository : ReadRepository<Vehicle>, IVehicleReadRepository
{
    public VehicleReadRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
