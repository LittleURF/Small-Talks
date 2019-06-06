using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index(List<Tag> tags)
        {
            var posts = await _dbContext.Posts
                .Include(p => p.Creator)
                .Include(p => p.PostTags)
                .Include(p => p.Comments)
                .ThenInclude(p => p.Comments)
                .OrderByDescending(p => p.CreationDate)
                .ToListAsync();

            //var tags = await _dbContext.Tags.ToListAsync();

            //foreach (var tag in tags)
            //{
            //    tag.IsActive = true;
            //}

            var model = new PostsWithTags { Posts = posts, Tags = tags };

            return View(model);
        }


        [HttpPost]
        [ActionName("Index")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IndexWithTags(List<Tag> tags)
        {
            var selectedTags = FilterTags(tags);

            if (selectedTags.Count() == 0)
            {
                // Display an error message, you cant select no tags
                return RedirectToAction(nameof(Index));
            }

            var posts = await _dbContext.Posts
                .Include(p => p.Creator)
                .Include(p => p.PostTags)
                .Include(p => p.Comments)
                .ThenInclude(p => p.Comments)
                .Where(c => c.PostTags.Any(pt => selectedTags.Contains(pt.Tag)))
                .OrderByDescending(p => p.CreationDate)
                .Take(2)
                .ToListAsync();

            await _dbContext.Tags.ToListAsync(); // Fills up Tags in the Posts

            var model = new PostsWithTags { Posts = posts, Tags = tags };


            return View(model);
        }

        [HttpPost]
        public object GetTags(List<Tag> tags)
        {
            var dataJson = Json(tags);
            return dataJson;
        }

        public async Task<IActionResult> GetMorePostsPartial(List<Tag> tags, int postsCount)
        {
            var selectedTags = FilterTags(tags);

            var posts = await _dbContext.Posts
                .Include(p => p.Creator)
                .Include(p => p.PostTags)
                .Include(p => p.Comments)
                .ThenInclude(p => p.Comments)
                .Where(c => c.PostTags.Any(pt => selectedTags.Contains(pt.Tag)))
                .OrderByDescending(p => p.CreationDate)
                .Skip(postsCount)
                .Take(1)
                .ToListAsync();

            await _dbContext.Tags.ToListAsync(); // Fills up Tags in the Posts

            var model = new PostsWithTags { Posts = posts, Tags = tags };

            return PartialView("_RenderPostsPartial", model);
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreatePost()
        {
            var user = await GetCurrentUserAsync();

            if (user.Points < 50)
            {
                //TODO Display error message
                return RedirectToAction(nameof(Index));
            }

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
            var user = await GetCurrentUserAsync();

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

                if (user.Points < 50)
                {
                    //TODO Display error message
                    return RedirectToAction(nameof(Index));
                }
                await SubstractPointsFromUserAsync(50);


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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        // This method serves only AJAX requests
        public async Task<Comment> AddComment(Comment model)
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

                await AddPointsToUserAsync(50);
                await _dbContext.Comments.AddAsync(comment);
                await _dbContext.SaveChangesAsync();
                return comment;
            }

            return null;


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
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


                await AddPointsToUserAsync(25);

                await _dbContext.ChildComments.AddAsync(comment);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));

        }

        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        private async Task AddPointsToUserAsync(int points)
        {
            var user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            user.Points += points;
        }

        private async Task SubstractPointsFromUserAsync(int points)
        {
            var user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            user.Points -= points;
        }

        private List<Tag> FilterTags(List<Tag> tags)
        {
            var selectedTags = new List<Tag>(tags);

            foreach (var tag in tags)
            {
                if (tag.IsActive == false)
                {
                    selectedTags.Remove(tag);
                }
            }
            return selectedTags;
        }
    }
}