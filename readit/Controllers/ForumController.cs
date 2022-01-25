using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;
using readit.Models;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ForumModel forumModel)
        {
            _appDbContext.Forums.Add(forumModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            var forumModel = await _appDbContext.Forums.FindAsync(id);

            if (id == null || forumModel == null)
            {
                return NotFound();
            }

            return View(forumModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {        
            var forumModel = await _appDbContext.Forums.FindAsync(id);

            if (id == null || forumModel == null)
            {
                return NotFound();
            }

            return View(forumModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ForumModel forumModel)
        {
            _appDbContext.Forums.Update(forumModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var forumModel = await _appDbContext.Forums.FindAsync(id);

            if (id == null || forumModel == null)
            {
                return NotFound();
            }

            return View(forumModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ForumModel forumModel)
        {
            _appDbContext.Forums.Remove(forumModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
