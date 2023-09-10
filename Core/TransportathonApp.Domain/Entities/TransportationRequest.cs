using System.ComponentModel.DataAnnotations;
using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Domain.Entities;

public class TransportationRequest : BaseEntity
{
    [Required]
    public string RequestType { get; set; }

    [Required]
    public string FromAddress { get; set; }

    [Required]
    public string ToAddress { get; set; }

    public DateTime TransportDate { get; set; }

    public double Weight { get; set; }

    // Diğer talep bilgileri eklenebilir (notlar, ek talepler, vb.).

    public Guid AppUserId { get; set; }
    public AppUser User { get; set; }

    //public Guid? ReservationId { get; set; }
    //public Reservation Reservation { get; set; }
}
