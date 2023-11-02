using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EncuestaValidacion.Models;

namespace EncuestaValidacion.Controllers;

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

    [HttpPost]
    [Route("/survey")]
    public IActionResult SurveyForm(Survey survey)
    {   
        Console.WriteLine("entre al método");
        Console.WriteLine(survey);
        if (!ModelState.IsValid)
        {   
            Console.WriteLine("entre al IFFFFFFFFFFFFFFF");
            // Si el modelo no es válido, muestra los errores y regresa al formulario.
            return View("Index");
        }
        
        // Procesa la encuesta aquí si el modelo es válido.

        // Redirige a la página de resultados o utiliza un modelo de vista para mostrar los resultados.
        return RedirectToAction("Privacy", survey);
    }
    [HttpGet]
    [Route("/result")]
    public IActionResult Privacy(Survey survey)
    {
        return View("Privacy",survey);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
