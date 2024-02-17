using Microsoft.AspNetCore.Mvc;
using Mission06_Olsen.Models;
using System.Diagnostics;

namespace Mission06_Olsen.Controllers
{
    public class HomeController : Controller
    {
        private MovieAdditionContext _context;

        public HomeController(MovieAdditionContext temp) 
        { 
            _context = temp;
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
      public IActionResult MovieAddition()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieAddition(MovieAddition response)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.MovieAddition.Add(response);
                    _context.SaveChanges();
                    return View("Confirmation", response);
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it appropriately
                    Debug.WriteLine($"Error saving changes: {ex.Message}");
                    ModelState.AddModelError("", "Error saving changes.");
                    return View(response);
                }
            }
            else
            {
                // Model validation failed, return the form with validation errors
                return View(response);
            }
        }

    }
}
