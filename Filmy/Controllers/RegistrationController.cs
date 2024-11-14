using Filmy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Filmy.Controllers
{
    public class RegistrationController : Controller
    {
        public static List<Registration> users = new List<Registration>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegistrationForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegistrationForm(Registration dane)
        {
            foreach (var user in users)
            {
                if (user.Email == dane.Email)
                {
                    ModelState.AddModelError("Email", "Email jest już zajęty");
                }
            }
            if (ModelState.IsValid)
            {
                users.Add(dane);
                return View("Result", dane);
            }
            else return View();
        }
    }
}
