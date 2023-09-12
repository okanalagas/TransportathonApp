using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Company : BaseEntity
{
    public string Name { get; set; }
    public int CompanyExecutiveId { get; set; }
    public CompanyExecutive CompanyExecutive { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
    public ICollection<Driver> Drivers { get; set; }
    public ICollection<TransportationTeam> TransportationTeams { get; set; }
    public ICollection<TransportationOffer> TransportationOffers { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}
