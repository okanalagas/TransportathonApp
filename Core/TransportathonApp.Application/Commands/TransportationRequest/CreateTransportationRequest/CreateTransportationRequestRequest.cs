using MediatR;
using TransportathonApp.Domain.Enums;

namespace TransportathonApp.Application.Commands.TransportationRequest.CreateTransportationRequest;

public class CreateTransportationRequestRequest : IRequest<CreateTransportationRequestResponse>
{
    public TransportationRequestType Type { get; set; }
    public string FromAddress { get; set; }
    public string ToAddress { get; set; }
    public string TransportDate { get; set; }
    public double? Weight { get; set; }
    public string Notes { get; set; }
    public string UserMail { get; set; }
}
