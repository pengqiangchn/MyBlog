using Domain.Modules.BlogAggs;
using Domain.Modules.BlogEntitys;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class BlogUserRepository : Repository<BlogUser>, IBlogUserRepository
    {
        private readonly UnitOfWork _context;

        public BlogUserRepository(UnitOfWork unitOfWork,
            ILogger<Repository<BlogUser>> logger)
            : base(unitOfWork, logger)
        {
            _context = unitOfWork;
        }

        public override BlogUser Get(object id)
        {
            BlogUser user = _context.BlogUsers
                .Include(x => x.BlogInfo)
                .FirstOrDefault(x => x.Id == Guid.Parse(id.ToString()));

            return user;
        }
    }
}