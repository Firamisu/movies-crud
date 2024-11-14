using Filmy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Filmy.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Data dane)
        {
            if (ModelState.IsValid)
            {
                return View("Result", dane);
            }
            else return View();
        }
        public IActionResult Wynik(Data dane)
        {
            return View(dane);
        }
    }
}
