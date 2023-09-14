using Microsoft.AspNetCore.Mvc;
using TransportathonApp.MVC.Models;

namespace TransportathonApp.MVC.Controllers.Account
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Account/Login/Login.cshtml");
        }

        public async Task<IActionResult> Login([FromBody] LoginViewModel vm)
        {
            return Json(new LoginViewModel
            {
                  Password = vm.Password,
                  Username = vm.Username,
            });
        }
    }
}
