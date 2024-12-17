using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Data;
using BookStoreApp.Models;
using System.Linq;

namespace BookStoreApp.Controllers
{
    public class AdminController : AdminBaseController
    {
        private readonly BookStoreContext _context;

        public AdminController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: Admin/ManageBooks
        public IActionResult ManageBooks()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

        // GET: Admin/CreateBook
        public IActionResult CreateBook()
        {
            var genres = _context.Books
                .Select(b => b.Genre)
                .Distinct()
                .Where(g => !string.IsNullOrEmpty(g))
                .ToList();

            ViewBag.Genres = genres; // Pass genres to the view
            return View();
        }

        // POST: Admin/CreateBook
        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction("ManageBooks");
            }

            // Reload genres if validation fails
            ViewBag.Genres = _context.Books
                .Select(b => b.Genre)
                .Distinct()
                .Where(g => !string.IsNullOrEmpty(g))
                .ToList();

            return View(book);
        }



        // GET: Admin/EditBook/{id}
        public IActionResult EditBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Admin/EditBook/{id}
        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Update(book);
                _context.SaveChanges();
                return RedirectToAction("ManageBooks");
            }
            return View(book);
        }

        // GET: Admin/DeleteBook/{id}
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Admin/DeleteBook/{id}
        [HttpPost, ActionName("DeleteBook")]
        public IActionResult DeleteBookConfirmed(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("ManageBooks");
        }


        // Manage Orders Actions
        public IActionResult ManageOrders()
        {
            var orders = _context.Orders.ToList();
            return View(orders);
        }

        public IActionResult UpdateOrderStatus(int id, string status)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                order.Status = status;
                _context.SaveChanges();
            }
            return RedirectToAction("ManageOrders");
        }
    }
}
