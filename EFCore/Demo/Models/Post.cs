using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
   public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }

        public ICollection<Reply> Replies { get; set; }
    }
}
