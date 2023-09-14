using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class CompanyController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Company/Views/Company/Company.cshtml");
    }
}
