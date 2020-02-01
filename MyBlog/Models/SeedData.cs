using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Context;
using MyBlog.Models.Entity;

namespace MyBlog.Models
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MyBlogContext(
                serviceProvider.GetRequiredService<DbContextOptions<MyBlogContext>>());
            if (context.BlogInfo.Any())
            {
                return;
            }

            context.BlogInfo.AddRange(
                new BlogInfo
                {
                    BlogId = Guid.NewGuid().ToString("N"),
                    BlogName = "MyBlog",
                    CreateTime = DateTime.Now
                }
            );
            context.SaveChanges();
        }
    }

}
