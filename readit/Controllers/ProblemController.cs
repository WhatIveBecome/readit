using Microsoft.AspNetCore.Mvc;

namespace readit.Models
{
    public class ProblemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
