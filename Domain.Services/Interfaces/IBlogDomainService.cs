using Domain.Modules.BlogAgg;
using Domain.Seedwork;
using Domain.Seedwork.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Interfaces
{
    public interface IBlogDomainService : IDomainService<Blog>
    {
        List<Blog> GetAllBlog();
    }
}
