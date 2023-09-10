using System.ComponentModel.DataAnnotations;
using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Vehicle : BaseEntity
{
    [Required]
    public string VehicleType { get; set; }
    [Required]
    public string PlateNumber { get; set; }
    public double Capacity { get; set; }

    public Guid CompanyId { get; set; }
    public Company Company { get; set; }

    public ICollection<Review> Reviews { get; set; }
}
