using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext()
        {

        }

        public DemoDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);

            if (!builder.IsConfigured)

                builder.UseSqlServer(Configuration.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>()
                .HasMany(c => c.Posts)
                .WithOne(p => p.Category).
                HasForeignKey(p => p.CategoryId);

            builder.Entity<Post>().
                HasMany(p => p.Replies).
                WithOne(r => r.Post).
                HasForeignKey(r => r.PostId).
                OnDelete(DeleteBehavior.Restrict);

            builder.Entity<User>().
              HasMany(p => p.Posts).
              WithOne(r => r.Author).
              HasForeignKey(r => r.AuthorId);

            builder.Entity<User>().
             HasMany(p => p.Replies).
             WithOne(r => r.Author).
             HasForeignKey(r => r.AuthorId);
        }

    }
}
