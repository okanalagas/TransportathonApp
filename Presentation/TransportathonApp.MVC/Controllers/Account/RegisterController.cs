using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransportathonApp.Application.Commands.Account.Register;

namespace TransportathonApp.MVC.Controllers.Account
{
    public class RegisterController : Controller
    {
        private readonly IMediator _mediator;

        public RegisterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View("/Views/Account/Register/Register.cshtml");
        }

        public async Task<IActionResult> CreateCustomer([FromBody]CreateCustomerRequest request)
        {
            CreateCustomerResponse response = await _mediator.Send(request);
            return Json(response);
        }

        public async Task<IActionResult> CreateCompanyExecutive([FromBody]CreateCompanyExecutiveRequest request)
        {
            CreateCompanyExecutiveResponse response = await _mediator.Send(request);
            return Json(response);
        }
    }
}
