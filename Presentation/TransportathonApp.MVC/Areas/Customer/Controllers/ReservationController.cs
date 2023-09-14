using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Customer.Controllers;

[Area("Customer")]
public class ReservationController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Customer/Views/Reservation/Reservation.cshtml");
    }
}
