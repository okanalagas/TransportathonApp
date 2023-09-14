using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class ReservationController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Company/Views/Reservation/Reservation.cshtml");
    }
}
