using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TransportathonApp.Application.Commands.TransportationRequest.CreateTransportationRequest;

namespace TransportathonApp.MVC.Areas.Customer.Controllers;

[Area("Customer")]
[Authorize(Roles = "Customer")]
public class RequestController : Controller
{
    private readonly IMediator _mediator;

    public RequestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public IActionResult Index()
    {
        return View("Areas/Customer/Views/Request/Request.cshtml");
    }
    public async Task<IActionResult> Create([FromBody] CreateTransportationRequestRequest request)
    {
        var response = await _mediator.Send(request);
        return Json(response);
    }
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}
