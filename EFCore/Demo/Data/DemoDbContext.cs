using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

    }
}
