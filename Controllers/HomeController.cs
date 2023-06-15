using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5.Models;

namespace TP5.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Habitacion1()
    {
        ViewBag.EstadoDeJuego = Escape.GetEstadoJuego();
        return View();
    }

    public IActionResult Habitacion2()
    {
        return View();
    }

    public IActionResult Habitacion3()
    {
        return View();
    }

    public IActionResult Habitacion4()
    {
        return View();
    }

    public IActionResult Habitacion5()
    {
        return View();
    }
    
    public IActionResult Habitacion6()
    {
        return View();
    }
    
    
    public IActionResult Habitacion7()
    {
        return View();
    }
    
    
    public IActionResult Habitacion8()
    {
        return View();
    }
    
    
    public IActionResult Habitacion9()
    {
        return View();
    }
    
    
    public IActionResult Habitacion10()
    {
        return View();
    }
    
    public IActionResult Tutorial()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
