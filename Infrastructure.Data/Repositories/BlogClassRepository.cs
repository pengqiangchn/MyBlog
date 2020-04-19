using Domain.Modules.BlogAggs;
using Domain.Modules.BlogEntitys;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class BlogClassRepository : Repository<BlogClass>, IBlogClassRepository
    {
        private readonly UnitOfWork context;

        public BlogClassRepository(UnitOfWork unitOfWork,
            ILogger<Repository<BlogClass>> logger)
            : base(unitOfWork, logger)
        {
            context = unitOfWork;
        }
        //public List<BlogClass> GetClassList(Guid blogId)
        //{
        //    var list = context.BlogClasses
        //        .Where(x => x.BlogId == blogId);

        //    return null;
        //}

    }
}