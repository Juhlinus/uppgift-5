using Microsoft.AspNet.Mvc;
using PersonalWebsite.Models;
using System.Linq;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Author.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "My contact information.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
