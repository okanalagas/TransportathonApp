using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransportathonApp.Application.Commands.TransportationOffer.CreateTransportationOffer;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class OfferController : Controller
{
    private readonly IMediator _mediator;

    public OfferController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public IActionResult Index()
    {
        return View("Areas/Company/Views/Offer/Offer.cshtml");
    }
    public async Task<IActionResult> Create([FromBody]CreateTransportationOfferRequest request)
    {
        CreateTransportationOfferResponse response = await _mediator.Send(request);
        return Json(response);
    }
}
