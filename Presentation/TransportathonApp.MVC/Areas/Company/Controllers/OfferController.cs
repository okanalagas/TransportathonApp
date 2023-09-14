using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class OfferController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Company/Views/Offer/Offer.cshtml");
    }
}
