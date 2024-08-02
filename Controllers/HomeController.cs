using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5_SalaDeEscape_Nieto.Models;

namespace TP5_SalaDeEscape_Nieto.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
public IActionResult CentralPerk()
    {
        return View();
    }
    public IActionResult DeptoMonica()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
