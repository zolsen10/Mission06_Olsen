using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Olsen.Models;
using System.Linq;
using System.Net.Mime;

namespace Mission06_Olsen.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieAdditionContext _context;

        public HomeController(MovieAdditionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movies(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();

                return View(response);
            }
            
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies.Include(x => x.Category).OrderBy(x => x.MovieId).ToList();
            return View(movies);
        }

        public IActionResult AllMovies()
        {
            var movies = _context.Movies.Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movieToEdit = _context.Movies.Single(x => x.MovieId == id);
            ViewBag.Categories = _context.Categories.ToList();
            return View("Movies", movieToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            _context.Update(movie);
            _context.SaveChanges();
            return RedirectToAction("AllMovies");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movieToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(movieToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("AllMovies");
        }
    }
}
