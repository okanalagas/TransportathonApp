using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Controllers.Error
{
    public class AccessDeniedController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Error/AccessDenied.cshtml");
        }
    }
}
