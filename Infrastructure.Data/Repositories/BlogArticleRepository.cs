using Domain.Modules.BlogArticleAgg;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data.Repositories
{
    public class BlogArticleRepository : Repository<BlogArticle>, IBlogArticleRepository
    {
        public BlogArticleRepository(UnitOfWorkDbContext unitOfWork,
            ILogger<Repository<BlogArticle>> logger)
            : base(unitOfWork, logger)
        {

        }
    }
}