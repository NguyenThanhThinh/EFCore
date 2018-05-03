using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
   public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
