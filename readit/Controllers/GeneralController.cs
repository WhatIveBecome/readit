using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;

namespace readit.Controllers
{
    public class GeneralController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public GeneralController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _appDbContext.General.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
