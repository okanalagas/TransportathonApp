using MediatR;
using Microsoft.AspNetCore.Identity;
using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Application.Commands.TransportationOffer.CreateTransportationOffer;

public class CreateTransportationOfferHandler : IRequestHandler<CreateTransportationOfferRequest, CreateTransportationOfferResponse>
{
    private readonly ITransportationOfferWriteRepository _transportationOfferWriteRepository;
    private readonly UserManager<AppUser> _userManager;

    public CreateTransportationOfferHandler(ITransportationOfferWriteRepository transportationOfferWriteRepository)
    {
        _transportationOfferWriteRepository = transportationOfferWriteRepository;
    }

    public async Task<CreateTransportationOfferResponse> Handle(CreateTransportationOfferRequest request, CancellationToken cancellationToken)
    {
        var user = _userManager.FindByEmailAsync(request.UserMail);
        await _transportationOfferWriteRepository.AddAsync(new Domain.Entities.TransportationOffer
        {
            CompanyExecutiveId = user.Id,
            DriverId = request.DriverId,
            VehicleId = request.VehicleId,
            TransportationTeamId = request.TeamId,
            Price = request.Price
        });
        await _transportationOfferWriteRepository.SaveAsync();
        return new();
    }
}
