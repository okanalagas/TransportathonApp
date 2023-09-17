using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransportathonApp.Application.Queries.TransportationRequest.GetTransportationRequest;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class RequestController : Controller
{
    private readonly IMediator _mediator;

    public RequestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public IActionResult Index()
    {
        return View("Areas/Company/Views/Request/Request.cshtml");
    }
    public async Task<IActionResult> Get([FromBody] GetTransportationRequestRequest request)
    {
        GetTransportationRequestResponse response = await _mediator.Send(request);
        return Json(response);
    }

    public async Task<IActionResult> Details()
    {
        return View("Areas/Company/Views/Request/RequestDetails.cshtml");
    }
}
