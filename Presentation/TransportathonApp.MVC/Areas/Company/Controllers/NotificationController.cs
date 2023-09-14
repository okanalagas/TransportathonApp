using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class NotificationController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Company/Views/Notification/Notification.cshtml");
    }
}
