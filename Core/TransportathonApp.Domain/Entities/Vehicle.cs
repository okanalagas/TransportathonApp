using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Enums;

namespace TransportathonApp.Domain.Entities;

public class Vehicle : BaseEntity
{
    public VehicleType VehicleType { get; set; }
    public int ModelYear { get; set; }
    public string? PlateNumber { get; set; }
    public double Capacity { get; set; }
    public int CompanyId { get; set; }
    public virtual Company Company { get; set; }
    public virtual ICollection<TransportationOffer> TransportationOffers { get; set; }
}
