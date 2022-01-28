using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;
using readit.Models;

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

        [HttpPost]
        public async Task<IActionResult> Create(GeneralModel generalModel)
        {
            _appDbContext.Add(generalModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var generalModel = await _appDbContext.General.FindAsync(id);

            if (id == null || generalModel == null)
            {
                return NotFound();
            }
            return View(generalModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(GeneralModel generalModel)
        {
            _appDbContext.Remove(generalModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit (int? id)
        {
            var generalModel = await _appDbContext.General.FindAsync(id);

            if (id == null || generalModel == null)
            {
                return NotFound();
            }

            return View(generalModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit (GeneralModel generalModel)
        {
            _appDbContext.General.Update(generalModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            var generalModel = await _appDbContext.General.FindAsync(id);
            if (id == null || generalModel == null) return NotFound();
            return View(generalModel);
        }
    }
}
