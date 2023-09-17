using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.MVC.Controllers.Account;


public class LogoutController : Controller
{
    private readonly SignInManager<AppUser> _signInManager;

    public LogoutController(SignInManager<AppUser> signInManager)
    {
        _signInManager = signInManager;
    }

    public async Task<IActionResult> Index()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}
