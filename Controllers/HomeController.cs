using Microsoft.AspNetCore.Mvc;
using ApprentissageInformatique.Models;
using ApprentissageInformatique.Data;

namespace ApprentissageInformatique.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var modules = SeedData.GetModules();
        return View(modules);
    }

    public IActionResult Apropos()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}
