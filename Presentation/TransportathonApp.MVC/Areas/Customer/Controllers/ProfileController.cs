using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Customer.Controllers;

[Area("Customer")]
public class ProfileController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Customer/Views/Profile/Profile.cshtml");
    }
}
