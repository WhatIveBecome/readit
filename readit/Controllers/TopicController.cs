using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;
using readit.Models;
using Microsoft.AspNetCore.Identity;

namespace readit.Controllers
{
    public class TopicController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        public TopicController(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _appDbContext.Topics.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(TopicModel topicModel)
        {
            topicModel.Description = $"{_userManager.GetUserName(User)}: {topicModel.Description}";
            topicModel.Author = _userManager.GetUserName(User);
            _appDbContext.Topics.Add(topicModel);
            await _appDbContext.SaveChangesAsync();
            TempData["success"] = "Topic successfully created";
            return RedirectToAction("Details", "Forum", new { id = topicModel.ForumModelId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TopicModel topicModel)
        {
            _appDbContext.Remove(topicModel);
            await _appDbContext.SaveChangesAsync();
            TempData["success"] = "Topic successfully deleted";
            return RedirectToAction("Index", "Forum"); // Action Back to previous id??
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var topicModel = await _appDbContext.Topics.FindAsync(id);

            if (id == null || topicModel == null)
            {
                return NotFound();
            }

            return View(topicModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TopicModel topicModel)
        {
            _appDbContext.Topics.Update(topicModel);
            await _appDbContext.SaveChangesAsync();
            TempData["success"] = "Topic successfully modified";
            return RedirectToAction("Details", "Forum", new { id = topicModel.ForumModelId });
        }

        public async Task<IActionResult> Details(int? id)
        {
            await _appDbContext.Replies.ToListAsync();
            var topicModel = await _appDbContext.Topics.FindAsync(id);

            if (id == null || topicModel == null)
            {
                return NotFound();
            }

            return View(topicModel);
        }
    }
}
