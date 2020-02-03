using Domain.Modules.BlogInfoAgg;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data.Repositories
{
    public class BlogInfoRepository : Repository<BlogInfo>, IBlogInfoRepository
    {
        public BlogInfoRepository(UnitOfWorkDbContext unitOfWork,
            ILogger<Repository<BlogInfo>> logger)
            : base(unitOfWork, logger)
        {

        }
    }
}