using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Forum.Models
{
    public class Topic
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        public string Subject { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime LastUpdate { get; set; }

        public bool isVisible { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Topic> Favorites { get; set; }

        public virtual ICollection<User> Likes { get; set; }

        public virtual ICollection<User> Views { get; set; }

        public Topic()
        {
            this.Id = Guid.NewGuid();
        }

        public Topic(User user, string subject, string title, string content)
        {
            this.Id = Guid.NewGuid();
            this.User = user;
            this.Subject = subject;
            this.Title = title;
            this.Content = content;
            this.LastUpdate = DateTime.Now;
            this.isVisible = true;
            this.Comments = new List<Comment>();
            this.Views = new List<User>();
        }
    }
}