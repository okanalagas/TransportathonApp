using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
