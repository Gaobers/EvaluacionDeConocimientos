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
            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;
            ViewBag.Num3 = num3;
            ViewBag.Num4 = num4;
            return View();
        }
    }
}
