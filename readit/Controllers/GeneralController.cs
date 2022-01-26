using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;

namespace readit.Controllers
{
    public class GeneralController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public IActionResult Index()
        {
            return View();       
        }
    }
}
