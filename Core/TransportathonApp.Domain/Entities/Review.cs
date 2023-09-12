using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Review : BaseEntity
{
    public int Rating { get; set; }
    public string? Comment { get; set; }
    public int ReservationId { get; set; }
    public Reservation Reservation { get; set; }
}
