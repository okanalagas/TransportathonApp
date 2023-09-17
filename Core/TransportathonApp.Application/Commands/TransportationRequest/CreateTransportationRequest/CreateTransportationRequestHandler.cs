using MediatR;
using Microsoft.AspNetCore.Identity;
using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Application.Commands.TransportationRequest.CreateTransportationRequest;

public class CreateTransportationRequestHandler : IRequestHandler<CreateTransportationRequestRequest, CreateTransportationRequestResponse>
{
    private readonly ITransportationRequestWriteRepository _transportationRequestWriteRepository;
    private readonly UserManager<AppUser> _userManager;
    public CreateTransportationRequestHandler(ITransportationRequestWriteRepository transportationRequestWriteRepository, UserManager<AppUser> userManager)
    {
        _transportationRequestWriteRepository = transportationRequestWriteRepository;
        _userManager = userManager;
    }
    public async Task<CreateTransportationRequestResponse> Handle(CreateTransportationRequestRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(request.UserMail);

        await _transportationRequestWriteRepository.AddAsync(new Domain.Entities.TransportationRequest
        {
            CustomerId = user.Id,
            FromAddress = request.FromAddress,
            ToAddress = request.ToAddress,
            Notes = request.Notes,
            TransportDate = DateTime.Parse(request.TransportDate),
            Type = request.Type,
            Weight = request.Weight
        });
        await _transportationRequestWriteRepository.SaveAsync();
        return new();
    }
}
