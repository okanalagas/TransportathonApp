using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class RequestController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Company/Views/Request/Request.cshtml");
    }
    public async Task<IActionResult> Details()
    {
        return View("Areas/Company/Views/Request/RequestDetails.cshtml");
    }
}
