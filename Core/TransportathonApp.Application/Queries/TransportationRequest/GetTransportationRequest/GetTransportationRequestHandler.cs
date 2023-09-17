using MediatR;
using TransportathonApp.Application.Repositories;

namespace TransportathonApp.Application.Queries.TransportationRequest.GetTransportationRequest;

public class GetTransportationRequestHandler : IRequestHandler<GetTransportationRequestRequest,GetTransportationRequestResponse>
{
    private readonly ITransportationRequestReadRepository _transportationRequestReadRepository;

    public GetTransportationRequestHandler(ITransportationRequestReadRepository transportationRequestReadRepository)
    {
        _transportationRequestReadRepository = transportationRequestReadRepository;
    }

    public async Task<GetTransportationRequestResponse> Handle(GetTransportationRequestRequest request, CancellationToken cancellationToken)
    {
        var transportationRequests = _transportationRequestReadRepository.GetAll(tracking: false).Select(tr => new
        {
            tr.Id,
            tr.FromAddress,
            tr.ToAddress,
            tr.Type,
            tr.TransportDate,
            tr.Weight,
            tr.Notes
        }).ToList();

        return new()
        {
            TransportationRequests = transportationRequests
        };

    }
}
