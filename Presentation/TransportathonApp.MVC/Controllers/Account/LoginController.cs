using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransportathonApp.Application.Commands.Account.Login;
using TransportathonApp.Application.Commands.Account.Register;
using TransportathonApp.Application.Exceptions;
using TransportathonApp.MVC.Models;

namespace TransportathonApp.MVC.Controllers.Account
{
    public class LoginController : Controller
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            if (User.Identity.Name == null)
            {
                return View("/Views/Account/Login/Login.cshtml");
            }
            if (User.IsInRole("Customer"))
                return RedirectToAction("","Customer");
            return RedirectToAction("","Company");

        }

        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                var response = await _mediator.Send(request); 

                return Json(response);
            }
            catch (LoginFailException ex)
            {                
                return Json(ex.Message);
            }
        }
    }
}
