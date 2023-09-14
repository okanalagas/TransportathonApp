using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Customer.Controllers;

[Area("Customer")]
public class MessageController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Customer/Views/Message/Message.cshtml");
    }
}
