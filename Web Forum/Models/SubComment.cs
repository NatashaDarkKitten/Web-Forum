using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Forum.Models
{
    public class SubComment : Comment
    { 
            public Guid CommentId { get; set; }
        public SubComment() : base()
        {
            CommentId = Guid.NewGuid();
        }

        public SubComment(Topic topic, User user, string content, Comment comment) : base(topic, user, content)
        {
            CommentId = Guid.NewGuid();
        }
    }
}