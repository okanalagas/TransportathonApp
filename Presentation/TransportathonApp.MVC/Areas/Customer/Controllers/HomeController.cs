using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TransportathonApp.Application.Commands.TransportationRequest.CreateTransportationRequest;

namespace TransportathonApp.MVC.Areas.Customer.Controllers;

[Area("Customer")]
[Authorize(Roles = "Customer")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    } 
}
