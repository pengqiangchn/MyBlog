using Domain.Modules.BlogAgg;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(UnitOfWork unitOfWork,
            ILogger<Repository<Blog>> logger)
            : base(unitOfWork, logger)
        {

        }
        /*
                #region Overrides

                public override IEnumerable<Blog> GetAll()
                {
                    var currentUnitOfWork = this.UnitOfWork as UnitOfWork;

                    var set = currentUnitOfWork.CreateSet<Blog>();

                    return set.Include("Posts.Images")
                        .AsEnumerable();
                }

                public override async Task<IEnumerable<Blog>> GetAllAsync()
                {
                    var currentUnitOfWork = this.UnitOfWork as UnitOfWork;

                    var set = currentUnitOfWork.CreateSet<Blog>();

                    return await set.Include("Posts.Images").ToListAsync();
                }
                #endregion
    */
    }
}