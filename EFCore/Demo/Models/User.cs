using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<Reply> Replies { get; set; } = new List<Reply>();
    }
}
