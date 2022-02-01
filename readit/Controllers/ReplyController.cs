using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;
using readit.Models;

namespace readit.Controllers
{
    public class ReplyController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ReplyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _appDbContext.Replies.ToListAsync());
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public async Task<IActionResult> Reply(ReplyModel replyModel)
        {
            _appDbContext.Add(replyModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
