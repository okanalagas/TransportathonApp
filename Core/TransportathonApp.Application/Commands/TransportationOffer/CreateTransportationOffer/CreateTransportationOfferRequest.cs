using MediatR;

namespace TransportathonApp.Application.Commands.TransportationOffer.CreateTransportationOffer;

public class CreateTransportationOfferRequest : IRequest<CreateTransportationOfferResponse>
{
    public string UserMail { get; set; }
    public int VehicleId { get; set; }
    public int DriverId { get; set; }
    public int TeamId { get; set; }
    public double Price { get; set; }
}
