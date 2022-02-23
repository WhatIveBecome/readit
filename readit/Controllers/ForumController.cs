using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;
using readit.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace readit.Controllers
{
    public class ForumController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly SignInManager<IdentityUser> _signInManager;
        public ForumController(AppDbContext appDbContext, SignInManager<IdentityUser> signInManager)
        {
            _appDbContext = appDbContext;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index(string name)
        {
            IQueryable<ForumModel> search = _appDbContext.Forums;

            if (!string.IsNullOrEmpty(name))
            {
                search = search.Where(x => x.Name.Contains(name));
            }
            var forumListingModels = search.Select(x => new ForumListingModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                NumberOfTopics = x.Topics.Count(),
            });

            var forums = await forumListingModels.ToListAsync();

            return View(forums);
        }

        public IActionResult Create()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return View();
            }
            return NotFound();
        }

        public async Task<IActionResult> CreateTopic(int? id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var forumModel = await _appDbContext.Forums.FindAsync(id);
                if (id == null || forumModel == null)
                {
                    return NotFound();
                }
                return View(forumModel);
            }
            return NotFound();
        }
        [Authorize(Roles = Roles.Admin)]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(ForumModel forumModel)
        {
            if (_signInManager.IsSignedIn(User))
            {
                _appDbContext.Forums.Add(forumModel);
                await _appDbContext.SaveChangesAsync();
                TempData["success"] = "Forum successfully created";
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public async Task<IActionResult> Details(int? id)
        {
            //var topicModel = _appDbContext.Topics;

            //var topicListingModels = topicModel.Select(x => new TopicListingModel
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    Description = x.Description,
            //    ForumModelId = x.ForumModelId, 
            //    NumberOfReplies = x.Replies.Count(),
            //});

            //await topicModel.ToListAsync();
            await _appDbContext.Topics.ToListAsync();
            var forumModel = await _appDbContext.Forums.FindAsync(id);
            if (id == null || forumModel == null)
            {
                return NotFound();
            }

            return View(forumModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var forumModel = await _appDbContext.Forums.FindAsync(id);

                if (id == null || forumModel == null)
                {
                    return NotFound();
                }

                return View(forumModel);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ForumModel forumModel)
        {
            if (_signInManager.IsSignedIn(User))
            {
                _appDbContext.Forums.Update(forumModel);
                await _appDbContext.SaveChangesAsync();
                TempData["success"] = "Forum successfully modified";
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ForumModel forumModel)
        {
            if (_signInManager.IsSignedIn(User))
            {
                _appDbContext.Forums.Remove(forumModel);
                await _appDbContext.SaveChangesAsync();
                TempData["success"] = "Forum successfully deleted";
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
