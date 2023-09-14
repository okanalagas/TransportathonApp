using MediatR;
using TransportathonApp.Application.Repositories;

namespace TransportathonApp.Application.Commands.TransportationRequest.CreateTransportationRequest;

public class CreateTransportationRequestHandler : IRequestHandler<CreateTransportationRequestRequest, CreateTransportationRequestResponse>
{
    private readonly ITransportationRequestWriteRepository _transportationRequestWriteRepository;
    public CreateTransportationRequestHandler(ITransportationRequestWriteRepository transportationRequestWriteRepository)
    {
        _transportationRequestWriteRepository = transportationRequestWriteRepository;
    }
    public async Task<CreateTransportationRequestResponse> Handle(CreateTransportationRequestRequest request, CancellationToken cancellationToken)
    {
        await _transportationRequestWriteRepository.AddAsync(new Domain.Entities.TransportationRequest{
            CustomerId = request.AppUserId,
            FromAddress = request.FromAddress,
            ToAddress = request.ToAddress,
            Notes = request.Notes,
            TransportDate = request.TransportDate,
            Type = request.Type,
            Weight = request.Weight
        });
        await _transportationRequestWriteRepository.SaveAsync();
        return new();
    }
}
