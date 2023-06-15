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
    [HttpPost] public IActionResult Habitacion(int sala, string clave) 
    {
        if(clave == null){
            clave = "null";
        }
        Escape.ResolverSala(sala, clave);
        if(Escape.GetEstadoJuego() != 5){
            return View("Habitacion"+ Escape.GetEstadoJuego());
        }else{
            return RedirectToAction("Victoria");
        }
    }

    public IActionResult Victoria()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Creditos()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
