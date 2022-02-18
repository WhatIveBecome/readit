using Microsoft.AspNetCore.Mvc;
using readit.Models;
using System.Diagnostics;

namespace readit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rules()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Development()
        {
            return View();
        }

        public IActionResult Features()
        {
            return View();
        }

        public IActionResult Bugs()
        {
            return View();
        }

        public IActionResult Review()
        {
            return View();
        }

        public IActionResult Accounts()
        {
            return View();
        }
    }
}