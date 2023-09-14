﻿using Microsoft.AspNetCore.Mvc;

namespace TransportathonApp.MVC.Areas.Company.Controllers;

[Area("Company")]
public class ProfileController : Controller
{
    public IActionResult Index()
    {
        return View("Areas/Company/Views/Profile/Profile.cshtml");
    }
}
