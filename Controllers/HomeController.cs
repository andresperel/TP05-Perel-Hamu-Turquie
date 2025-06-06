using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_Perel_Hamu_Turquie.Models;
using Newtonsoft.Json;

namespace TP05_Perel_Hamu_Turquie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
    }

    public IActionResult intro()
    {
        salaEscape sala = new salaEscape();
        sala.inicializarJuego();
        HttpContext.Session.SetString("sala", objeto.ObjectToString(sala));
        return View("intro");
    }
    public IActionResult jugar(string intento)
    {
        salaEscape sala = objeto.StringToObject<salaEscape>(HttpContext.Session.GetString("sala"));
        
        sala.comprobarClave(intento);
        ViewBag.pista = sala.devolverPista();
        HttpContext.Session.SetString("sala", objeto.ObjectToString(sala));

        return View("sala" + sala.nroSala);
    }

    public IActionResult creditos()
    {
        return View("creditos");
    }

}
