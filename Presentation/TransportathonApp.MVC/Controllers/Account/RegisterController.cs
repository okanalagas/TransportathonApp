using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Controllers.Account
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Account/Register/Register.cshtml");
        }
    }
}
