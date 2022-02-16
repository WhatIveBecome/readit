using Microsoft.AspNetCore.Mvc;

namespace readit.Models
{
    public class BugController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
