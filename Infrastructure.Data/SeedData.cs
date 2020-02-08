
namespace Infrastructure.Data
{
    //注释,等后期不要了, 就把这个类删掉
    /*  public static class SeedData
      {
          public static void Initialize(IServiceProvider serviceProvider)
          {
              using var context = new UnitOfWork(
                  serviceProvider.GetRequiredService<DbContextOptions<UnitOfWork>>());
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
      */

}
