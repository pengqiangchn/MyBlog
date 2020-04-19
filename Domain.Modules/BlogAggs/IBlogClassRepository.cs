using Domain.Modules.BlogEntitys;
using Domain.Seedwork;
using System;
using System.Collections.Generic;

namespace Domain.Modules.BlogAggs
{
    public interface IBlogClassRepository : IRepository<BlogClass>
    {
        //List<BlogClass> GetClassList(Guid blogId);
    }
}