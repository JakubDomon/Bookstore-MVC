using Bookstore_MVC.Data;
using Bookstore_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDBContext _db;

        public BookController(AppDBContext database)
        {
            _db = database;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> objBooksList = _db.Books.ToList();
            return View(objBooksList);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                // Assign creation date to book obj
                book.CreatedAt = DateTime.Now;
                // Save book to database
                _db.Books.Add(book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}
