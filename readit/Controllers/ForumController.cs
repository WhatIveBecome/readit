using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;

namespace readit.Controllers
{
    public class ForumController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public ForumController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _appDbContext.Forums.ToListAsync());
        }
    }
}
