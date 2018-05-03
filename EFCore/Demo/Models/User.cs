using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Post> Posts { get; set; }

        public ICollection<Reply>   Replies { get; set; }
    }
}
