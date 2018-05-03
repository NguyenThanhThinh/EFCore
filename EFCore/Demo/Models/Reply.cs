using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Models
{
  public  class Reply
    {
        public int Id { get; set; }
     
        public string Content { get; set; }
        
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
