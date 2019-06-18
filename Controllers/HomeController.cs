using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SmallTalks.Data;
using SmallTalks.Enums;
using SmallTalks.Models;
using SmallTalks.ViewModels;

namespace SmallTalks.Controllers
{
    /*
     * Make more dummy data, with microsoft documentation
     * Make login check if user is banned(notes in notepad)
     * 
     * Add some relatively positioned ornaments
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

        [TempData]
        public string TempMessage { get; set; }


        public async Task<IActionResult> Index()
        {
            var tags = await _dbContext.Tags.ToListAsync();

            foreach (var tag in tags)
            {
                tag.IsActive = true;
            }

            var posts = await GetPosts(5, tags);

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
                TempMessage = "You have to select at least one tag";

                return RedirectToAction(nameof(Index));
            }

            var posts = await GetPosts(5, selectedTags);

            var model = new PostsWithTags { Posts = posts, Tags = tags };

            return View(model);
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreatePost()
        {
            var user = await GetCurrentUserAsync();

            if (user.Points < 50)
            {
                TempMessage = "You don't have enough points to create a post. For more info check the Instructions page";
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
                    TempMessage = "You don't have enough points to create a post. For more info check the Instructions page";
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
            TempMessage = "Created comment succesfully";
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        //This method exits only to pass data to the View rendering Ajax calls
        public object GetTags(List<Tag> tags)
        {
            var tagsJson = Json(tags);
            return tagsJson;
        }


        public async Task<IActionResult> GetMorePostsPartial(List<Tag> tags, int postsCount)
        {
            var selectedTags = FilterTags(tags);

            var posts = await GetPosts(2, tags, postsCount);

            await _dbContext.Tags.LoadAsync(); // Fills up Tags in the Posts

            var model = new PostsWithTags { Posts = posts, Tags = tags };

            return PartialView("_RenderPostsPartial", model);
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

            throw new ArgumentException("The comment did not pass the required validation");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ChildComment> AddChildComment(ChildComment model)
        {
            if (ModelState.IsValid)
            {
                var childComment = new ChildComment
                {
                    Content = model.Content,
                    PostId = model.PostId,
                    CreationDate = DateTime.Now,
                    CreatorId = User.FindFirst(ClaimTypes.NameIdentifier).Value,    // Gets current user Id
                    CommentId = model.CommentId
                };


                await AddPointsToUserAsync(25);

                await _dbContext.ChildComments.AddAsync(childComment);
                await _dbContext.SaveChangesAsync();
                return childComment;
            }
            ;
            throw new ArgumentException("The comment did not pass the required validation");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<object> SendReport(int objectId, string objectType, string content)
        {
            var user = await GetCurrentUserAsync();

            var newReport = new Report
            {
                ReporterId = user.Id,
                ReportedObjectId = objectId,
                ReportedObjectType = Enum.Parse<ObjectType>(objectType),
                Content = content
            };

            await _dbContext.Reports.AddAsync(newReport);
            await _dbContext.SaveChangesAsync();

            return Json(new { objectId, objectType });

        }

        public IActionResult GetCommentPartial(Comment comment)
        {

            return PartialView("_CommentPartial", comment);
        }

        public IActionResult GetChildCommentPartial(ChildComment childComment)
        {

            return PartialView("_ChildCommentPartial", childComment);
        }

        private async Task<List<Post>> GetPosts(int amount, List<Tag> tags)
        {


            var unwantedTagsJson = JsonConvert.SerializeObject(tags);
            var wantedTags = JsonConvert.DeserializeObject<List<Tag>>(unwantedTagsJson);

            wantedTags.Where(t => t.IsActive == true);


            var posts = await _dbContext.Posts
               .Include(p => p.Creator)
               .Include(p => p.PostTags)
               .Include(p => p.Comments).ThenInclude(c => c.Creator)
               .Include(p => p.Comments).ThenInclude(c => c.Comments)
               .Where(p => p.PostTags.All(pt => wantedTags.Any(t => t == pt.Tag)))
               .OrderByDescending(p => p.CreationDate)
               .Take(amount)
               .ToListAsync();

            await _dbContext.Users
                    .Where(u => posts.Any(p => p.Comments.Any(c => c.Comments.Any(cc => cc.CreatorId == u.Id))))
                    .LoadAsync();

            await _dbContext.Tags.LoadAsync(); // Fills up Tags in the Posts

            return posts;
        }

        private async Task<List<Post>> GetPosts(int amount, List<Tag> tags, int postsToSkip)
        {
            var unwantedTagsJson = JsonConvert.SerializeObject(tags);
            var wantedTags = JsonConvert.DeserializeObject<List<Tag>>(unwantedTagsJson).Where(t => t.IsActive == true).ToList();

            var posts = await _dbContext.Posts
                .Include(p => p.Creator)
                .Include(p => p.PostTags)
                .Include(p => p.Comments).ThenInclude(c => c.Creator)
                .Include(p => p.Comments).ThenInclude(c => c.Comments)
                .Where(p => p.PostTags.All(pt => wantedTags.Any(t => t == pt.Tag)))
                .OrderByDescending(p => p.CreationDate)
                .Skip(postsToSkip)
                .Take(amount)
                .ToListAsync();

            await _dbContext.Users
                    .Where(u => posts.Any(p => p.Comments.Any(c => c.Comments.Any(cc => cc.CreatorId == u.Id))))
                    .LoadAsync();

            await _dbContext.Tags.ToListAsync(); // Fills up Tags in the Posts

            return posts;
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
    }
}