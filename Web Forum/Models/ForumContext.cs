using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Web_Forum.Models;

namespace Web_Forum.Models
{
    public class ForumContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public DbSet<SubComment> SubComments { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<User> Users { get; set; }

        //public ForumContext() : base("DefaultConnection") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(c => c.Topics)
                .WithMany(s => s.Users)
                .Map(t => t.MapLeftKey("Id")
                .MapRightKey("Id")
                .ToTable("CourseStudent"));
        }

    }


}