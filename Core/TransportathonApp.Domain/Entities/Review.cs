using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Review : BaseEntity
{
    public int Rating { get; set; }

    public string Comment { get; set; }

    public Guid TransportationRequestId { get; set; }
    public TransportationRequest TransportationRequest { get; set; }

    // Diğer değerlendirme bilgileri eklenebilir.
}
