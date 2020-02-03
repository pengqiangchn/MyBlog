using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Infrastructure.Data.UnitOfWorks;
using Domain.Modules.BlogInfoAgg;

namespace Infrastructure.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new UnitOfWorkDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<UnitOfWorkDbContext>>());
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
