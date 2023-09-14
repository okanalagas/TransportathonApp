using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransportathonApp.Application.Commands.TransportationRequest.CreateTransportationRequest;

namespace TransportathonApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportationRequestsController : ControllerBase
    {
        readonly IMediator _mediator;
        public TransportationRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(CreateTransportationRequestRequest request)
        {
           CreateTransportationRequestResponse response= await _mediator.Send(request);
            return Ok(response);
        }
    }
}
