using Domain.Modules.BlogAggs;
using Domain.Modules.BlogEntitys;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data.Repositories
{
    public class BlogInfoRepository : Repository<BlogInfo>, IBlogInfoRepository
    {
        private readonly UnitOfWork unitOfWork;

        public BlogInfoRepository(UnitOfWork unitOfWork,
            ILogger<Repository<BlogInfo>> logger)
            : base(unitOfWork, logger)
        {
            this.unitOfWork = unitOfWork;
        }

    }
}