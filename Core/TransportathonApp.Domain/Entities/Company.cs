using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Company : BaseEntity
{

    // Other company-related properties can be added as needed.

    public ICollection<Vehicle> Vehicles { get; set; }
    public ICollection<Driver> Drivers { get; set; }
}
