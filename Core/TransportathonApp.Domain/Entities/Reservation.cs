using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Reservation : BaseEntity
{
    public DateTime ReservationDate { get; set; }

    //public Guid TransportationRequestId { get; set; }
    //public TransportationRequest TransportationRequest { get; set; }

    // Diğer rezervasyon bilgileri eklenebilir.
}
