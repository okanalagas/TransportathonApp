using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Controllers.Account
{
    public class ForgotPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Account/ForgotPassword/ForgotPassword.cshtml");
        }
    }
}
