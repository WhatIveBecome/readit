using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;
using readit.Models;
using Microsoft.AspNetCore.Identity;

namespace readit.Controllers
{
    public class ReplyController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public ReplyController(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _appDbContext.Replies.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Reply(ReplyModel replyModel)
        {
            replyModel.Description = $"{_userManager.GetUserName(User)}: {replyModel.Description}";
            _appDbContext.Add(replyModel);
            await _appDbContext.SaveChangesAsync();
            TempData["success"] = "Reply successfully added";
            return RedirectToAction("Details", "Topic", new { id = replyModel.TopicModelId });
        }
    }
}
