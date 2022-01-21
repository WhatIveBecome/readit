using Microsoft.AspNetCore.Mvc;

namespace readit.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
