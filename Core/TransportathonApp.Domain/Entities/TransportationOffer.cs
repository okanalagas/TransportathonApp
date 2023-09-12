using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class TransportationOffer : BaseEntity
{
    public int CompanyExecutiveId { get; set; }
    public CompanyExecutive CompanyExecutive { get; set; }
    public int VehicleId { get; set; }
    public virtual Vehicle Vehicle { get; set; }
    public int DriverId { get; set; }
    public virtual Driver Driver { get; set; }
    public int TransportationTeamId { get; set; }
    public virtual TransportationTeam TransportationTeam { get; set; }
}
