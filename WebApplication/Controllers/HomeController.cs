using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(ErrorViewModel user)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Message = $"Welcome, {user.Name}!";
            return View(user);
        }

        return View(user);
    }
}
