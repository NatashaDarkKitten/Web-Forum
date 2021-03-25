using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Forum.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Topic Topic { get; set; }

        public User User { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual ICollection<SubComment> SubComments { get; set; }

        public Comment()
        {
            this.Id = Guid.NewGuid();
        }

        public Comment(Topic topic, User user, string content)
        {
            this.Id = Guid.NewGuid();
            this.Topic = topic;
            this.User = user;
            this.Content = content;
            this.CreationDate = DateTime.Now;
            this.SubComments = new List<SubComment>();
        }
    }
}