using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmallTalks.Models;

namespace SmallTalks.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PostTags>()
                .HasKey(pt => new { pt.PostId, pt.TagId });

            modelBuilder.Entity<ApplicationUser>()
                 .HasMany(e => e.Roles)
                 .WithOne()
                 .HasForeignKey(e => e.UserId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ChildComment> ChildComments { get; set; }
        public DbSet<PostTags> PostTags { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Ban> Bans { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public  List<ApplicationUser> GetUsersWithRole(string roleId)
        {
            var users = Users
                .Include(u => u.Roles)
                .Where(u => u.Roles.Any(r => r.RoleId == roleId))
                .ToList();

            return users;
        }
    }
}
