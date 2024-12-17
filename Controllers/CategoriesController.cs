using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Data;
using System.Linq;

namespace BookStoreApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly BookStoreContext _context;

        public CategoriesController(BookStoreContext context)
        {
            _context = context;
        }

        // Display all genres
        public IActionResult Index()
        {
            var genres = _context.Books
                .Select(b => b.Genre)
                .Distinct()
                .Where(g => g != null)
                .ToList();

            return View(genres);
        }

        // Display books by genre
        public IActionResult BooksByGenre(string genre)
        {
            var books = _context.Books
                .Where(b => b.Genre == genre)
                .ToList();

            ViewBag.Genre = genre; // Pass the genre name to the view
            return View(books);
        }
    }
}
