using Microsoft.AspNetCore.Mvc;

namespace GEOG23022026AppMVC.Controllers
{
    public class GabrielPromedioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double num1, double num2, double num3, double num4)
        {
            double promedio = (num1 + num2 + num3 + num4) / 4;
            ViewBag.Promedio = promedio;
            return View();
        }
    }
}
