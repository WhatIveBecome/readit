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
        private readonly SignInManager<IdentityUser> _signInManager;
        public TopicController(AppDbContext appDbContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _appDbContext.Topics.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(TopicModel topicModel)
        {
            if (_signInManager.IsSignedIn(User))
            {
                topicModel.FullDescription = $"{_userManager.GetUserName(User)}: {topicModel.Description}";
                topicModel.Author = _userManager.GetUserName(User);
                _appDbContext.Topics.Add(topicModel);
                await _appDbContext.SaveChangesAsync();
                TempData["success"] = "Topic successfully created";
                return RedirectToAction("Details", "Forum", new { id = topicModel.ForumModelId });
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TopicModel topicModel)
        {
            if (_signInManager.IsSignedIn(User))
            {
                _appDbContext.Remove(topicModel);
                await _appDbContext.SaveChangesAsync();
                TempData["success"] = "Topic successfully deleted";
                return RedirectToAction("Index", "Forum"); // Action Back to previous id??
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var topicModel = await _appDbContext.Topics.FindAsync(id);

                if (id == null || topicModel == null)
                {
                    return NotFound();
                }
                return View(topicModel);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TopicModel topicModel)
        {
            if (_signInManager.IsSignedIn(User))
            {
                _appDbContext.Topics.Update(topicModel);
                await _appDbContext.SaveChangesAsync();
                TempData["success"] = "Topic successfully modified";
                return RedirectToAction("Details", "Forum", new { id = topicModel.ForumModelId });
            }
            return NotFound();
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
