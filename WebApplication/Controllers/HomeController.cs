using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers;

public class HomeController : Controller
{
    // GET: Form
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    // POST: Form
    [HttpPost]
    public IActionResult Index(ErrorViewModel user)
    {
        if (ModelState.IsValid)
        {
            // If the model is valid, display a welcome message with the user's name
            ViewBag.Message = $"Welcome, {user.Name}!";
            return View(user);
        }

        return View(user);
    }
}
