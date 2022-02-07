﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using readit.Database;
using readit.Models;

namespace readit.Controllers
{
    public class TopicController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TopicController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _appDbContext.Topics.ToListAsync());
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}
        //public async Task<IActionResult> Create(int? id)
        //{
        //    var forumModel = await _appDbContext.Forums.FindAsync(id);
        //    if (id == null || forumModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View();
        //}

        [HttpPost]
        public async Task<IActionResult> Create(TopicModel topicModel)
        {
            //var forumModel = new ForumModel();
            
            _appDbContext.Topics.Add(topicModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Details", "Forum", new { id = topicModel.ForumModelId });
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var topicModel = await _appDbContext.Topics.FindAsync(id);

            if (id == null || topicModel == null)
            {
                return NotFound();
            }
            return View(topicModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TopicModel topicModel)
        {
            _appDbContext.Remove(topicModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
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
