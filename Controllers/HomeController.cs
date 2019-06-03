using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmallTalks.Data;
using SmallTalks.Models;
using SmallTalks.ViewModels;

namespace SmallTalks.Controllers
{
    /*
     * 
     * 
    */
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;


        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IActionResult> Index()
        {
            var posts = await _dbContext.Posts
                .Include(p => p.Creator)
                .Include(p => p.PostTags)
                .Include(p => p.Comments)
                .OrderByDescending(p => p.CreationDate)
                .ToListAsync();

            await _dbContext.Comments.Include(c => c.Comments).ToListAsync(); // This line is needed to properly get Child comments in the posts object. TODO

            var tags = await _dbContext.Tags.ToListAsync();

            foreach (var tag in tags)
            {
                tag.IsActive = true;
            }

            var model = new PostsWithTags { Posts = posts, Tags = tags };

            return View(model);
        }



        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreatePost()
        {
            var model = new PostWithTags();

            model.Tags = await _dbContext.Tags.ToListAsync();
            return View(model);
        }

        [HttpPost]
        [ActionName("CreatePost")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreatePostSubmitted(PostWithTags model)
        {
            if (ModelState.IsValid)
            {
                // Adds the Post to the  DB Posts Table
                var post = new Post
                {
                    Title = model.Post.Title,
                    Content = model.Post.Content,
                    CreationDate = DateTime.Now,
                    CreatorId = User.FindFirst(ClaimTypes.NameIdentifier).Value    // Gets current user Id
                };

                await _dbContext.Posts.AddAsync(post);
                await _dbContext.SaveChangesAsync(); // Needed to get proper PostId

                // Adds the Post&tags related data to the DB PostTags Table
                foreach (var tag in model.Tags)
                {
                    if (tag.IsActive)
                    {
                        var postTags = new PostTags
                        {
                            PostId = post.Id,
                            TagId = tag.Id
                        };

                        await _dbContext.PostTags.AddAsync(postTags);
                    }
                }

                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AddComment(Comment model)
        {
            if (ModelState.IsValid)
            {
                var comment = new Comment
                {
                    Content = model.Content,
                    PostId = model.PostId,
                    CreationDate = DateTime.Now,
                    CreatorId = User.FindFirst(ClaimTypes.NameIdentifier).Value,    // Gets current user Id
                };


                await _dbContext.Comments.AddAsync(comment);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> AddChildComment(ChildComment model)
        {
            if (ModelState.IsValid)
            {
                var comment = new ChildComment
                {
                    Content = model.Content,
                    PostId = model.PostId,
                    CreationDate = DateTime.Now,
                    CreatorId = User.FindFirst(ClaimTypes.NameIdentifier).Value,    // Gets current user Id
                    CommentId = model.CommentId
                };


                await _dbContext.ChildComments.AddAsync(comment);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));

        }
    }
}