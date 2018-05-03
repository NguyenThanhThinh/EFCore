using System;
namespace Demo
{
    using Demo.Data;
    using Demo.Models;

    public class Startup
    {
        static void Main(string[] args)
        {
            var context = new DemoDbContext();

            var users = new[]
            {
                new User("thanhthinh","123456"),

                new User("vanteo","7654321"),
            };

            context.Users.AddRange(users);

            context.SaveChanges();

        }
    }
}
