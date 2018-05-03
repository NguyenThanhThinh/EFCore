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
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
