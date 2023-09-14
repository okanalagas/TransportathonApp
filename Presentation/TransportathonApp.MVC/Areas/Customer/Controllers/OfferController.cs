using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Customer.Controllers;

[Area("Customer")]
public class OfferController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Customer/Views/Offer/Offer.cshtml");
    }
}
