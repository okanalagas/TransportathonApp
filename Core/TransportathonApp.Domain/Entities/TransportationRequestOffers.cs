using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class TransportationRequestOffers : BaseEntity
{
    public int TransportationRequestId { get; set; }
    public virtual TransportationRequest Request { get; set; }
    public int TransportationOfferId { get; set; }
    public virtual TransportationOffer TransportationOffer { get; set; }
}
