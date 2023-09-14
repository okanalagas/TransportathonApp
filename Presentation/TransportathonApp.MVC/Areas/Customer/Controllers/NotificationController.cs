using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Customer.Controllers;

[Area("Customer")]
public class NotificationController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Customer/Views/Notification/Notification.cshtml");
    }
}
