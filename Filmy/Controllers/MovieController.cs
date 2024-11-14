using Filmy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filmy.Controllers
{
    public class MovieController : Controller
    {
        //movie list
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie { Id = 1, Name = "Shrek", Description = "An ogre", Price = 10 },
            new Movie { Id = 2, Name="Avatar", Description="A marine on an alien planet", Price=20 },
            new Movie { Id = 3, Name="The Matrix", Description="A computer hacker learns about the true nature of reality", Price=30 }
        };
        // GET: MovieController
        public ActionResult Index()
        {
            return View(_movies);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View(_movies.FirstOrDefault(x => x.Id == id));
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View(new Movie());
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            movie.Id = _movies.Count + 1;
            _movies.Add(movie);
            
            return RedirectToAction(nameof(Index));
            
          
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_movies.FirstOrDefault(x => x.Id == id));
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Movie mov)
        {    

            Movie movie = _movies.FirstOrDefault(x => x.Id == id);
            movie.Name = mov.Name;
            movie.Description = mov.Description;
            movie.Price = mov.Price;


            return RedirectToAction(nameof(Index));
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_movies.FirstOrDefault(x => x.Id == id));
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _ = _movies.Remove(_movies.FirstOrDefault(x => x.Id == id));
           return RedirectToAction(nameof(Index));
           
        }
    }
}
