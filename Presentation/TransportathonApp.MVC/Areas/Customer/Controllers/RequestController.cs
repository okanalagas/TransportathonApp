using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Customer.Controllers;

[Area("Customer")]
public class RequestController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Customer/Views/Request/Request.cshtml");
    }
    public async Task<IActionResult> Create()
    {
        return Ok();
    }
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}
