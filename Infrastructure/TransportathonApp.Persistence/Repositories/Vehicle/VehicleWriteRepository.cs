using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class VehicleWriteRepository : WriteRepository<Vehicle>, IVehicleWriteRepository
{
    public VehicleWriteRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
