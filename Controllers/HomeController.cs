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

    // Acción POST que valida la respuesta
 [HttpPost]
public IActionResult Habitacion(int sala, int respuesta)
{
    // Obtener las opciones y las pistas de la sala actual
    var opciones = Escape.ObtenerOpcionesSala(sala);
    var pistas = Escape.ObtenerPistasSala(sala);
    var pregunta = Escape.ObtenerPreguntaSala(sala);

    // Verificar si la respuesta es correcta utilizando el método ResolverSala
    if (Escape.ResolverSala(sala, respuesta))
    {
        // Si la respuesta es correcta, verificar si el juego ha terminado
        if (Escape.GetEstadoJuego() != 9)
        {   
            opciones = Escape.ObtenerOpcionesSala(sala+1);
            pistas = Escape.ObtenerPistasSala(sala+1);
            pregunta = Escape.ObtenerPreguntaSala(sala+1);
            // Pasar las opciones, pistas y pregunta a ViewBag para mostrarlas en la vista
            ViewBag.Opcion1 = opciones.Item1;
            ViewBag.Opcion2 = opciones.Item2;
            ViewBag.Opcion3 = opciones.Item3;
            ViewBag.Pista1 = pistas.Item1;
            ViewBag.Pista2 = pistas.Item2;
            ViewBag.Pista3 = pistas.Item3;
            ViewBag.Pregunta = pregunta;
            ViewBag.Sala = sala + 1;

            // Mostrar la vista de la misma sala para continuar el juego
            return View("Habitacion");
        }
        else
        {
            // Si el juego ha terminado, redirigir a la página de victoria
            return RedirectToAction("Victoria");
        }
    }
    else
    {
        // Si la respuesta es incorrecta, seguir mostrando la misma sala con las opciones y pistas
        ViewBag.Opcion1 = opciones.Item1;
        ViewBag.Opcion2 = opciones.Item2;
        ViewBag.Opcion3 = opciones.Item3;
        ViewBag.Pista1 = pistas.Item1;
        ViewBag.Pista2 = pistas.Item2;
        ViewBag.Pista3 = pistas.Item3;
        ViewBag.Pregunta = pregunta;
        ViewBag.Sala = sala;

        // Mostrar la misma vista de la habitación
        return View("Habitacion");
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
