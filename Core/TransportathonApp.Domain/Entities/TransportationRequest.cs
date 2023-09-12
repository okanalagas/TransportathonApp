using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Enums;

namespace TransportathonApp.Domain.Entities;

public class TransportationRequest : BaseEntity
{
    public TransportationRequestType Type { get; set; }
    public string FromAddress { get; set; }
    public string ToAddress { get; set; }
    public DateTime TransportDate { get; set; }
    public double? Weight { get; set; }
    public string Notes { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
}
