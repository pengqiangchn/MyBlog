using Microsoft.EntityFrameworkCore;
using MyBlog.Models.Entity;

namespace MyBlog.Context
{
    public class MyBlogContext : DbContext
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
        }

        public DbSet<BlogInfo> BlogInfo { get; set; }

        public DbSet<BlogClass> BlogClass { get; set; }

        public DbSet<BlogArticle> BlogArticle { get; set; }

    }
}
