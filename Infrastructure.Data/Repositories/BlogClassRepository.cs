using Domain.Modules.BlogClassAgg;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data.Repositories
{
    public class BlogClassRepository : Repository<BlogClass>, IBlogClassRepository
    {
        public BlogClassRepository(UnitOfWorkDbContext unitOfWork,
            ILogger<Repository<BlogClass>> logger)
            : base(unitOfWork, logger)
        {

        }
    }
}