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
public IActionResult Comenzar()
    {
        int estadoJuego = Escape.GetEstadoJuego();
        string view;
        if(estadoJuego != 6){
        view = "Habitacion" + estadoJuego;
        } else{
        view = "Victoria";
        }
        return View(view);
    }
    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Habitacion(int sala, string clave)
    {
      int estadoJuego = Escape.GetEstadoJuego();

        //Para evitar que se pueda saltear salas manipulando informacion a traves de la URL
    if(sala != estadoJuego){
        estadoJuego = sala;
        return View("Habitacion"+estadoJuego); 

    }
    if(Escape.ResolverSala(sala, clave)){ 
        estadoJuego++;
        if(estadoJuego == 6){
                return RedirectToAction("Victoria");
        } else{
            
        return View("Habitacion" + estadoJuego);

        }
         
       
    } else{
        ViewBag.Error = "LA RESPUESTA ES INCORRECTA";
        return View("Habitacion" + estadoJuego);
    }
    }
    public IActionResult Victoria()
    {
        return View();
    }
 
    public IActionResult Privacy()
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
//No pone imagen de fondo 
//No pone la imagen de juegos mentales --> no está bien el camino?
//Cambiarle el color a links para que no se vean subrayados y azules
//No entra a las pistas (me gustaria que haya un limite de pistas que se pueden usar)
//No deja seguir de sala uno a dos porque el vector con rtas correctas nunca se inicializa


