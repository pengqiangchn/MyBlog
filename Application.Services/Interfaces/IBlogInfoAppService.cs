using Domain.Modules.BlogInfoAgg;
using System;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface IBlogInfoAppService
    {
        IList<BlogInfo> GetAllBlog();
    }
}
