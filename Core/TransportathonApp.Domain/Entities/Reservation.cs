using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Enums;

namespace TransportathonApp.Domain.Entities;

public class Reservation : BaseEntity
{
    public int TransportationRequestId { get; set; }
    public TransportationRequest TransportationRequest { get; set; }
    public int TransportationOfferId { get; set; }
    public TransportationOffer TransportationOffer { get; set; }
    public TransportationStatus TransportationStatus { get; set; }
    public virtual ICollection<Message> Messages { get; set; }
    public int? ReviewId { get; set; }
    public virtual Review Review { get; set; }
}
