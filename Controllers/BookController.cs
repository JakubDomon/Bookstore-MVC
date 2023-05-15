using Microsoft.AspNetCore.Mvc;

namespace Bookstore_MVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
