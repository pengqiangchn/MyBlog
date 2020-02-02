using Domain.Modules.BlogAgg;
using System;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface IBlogAppService
    {
        IList<Blog> GetAllBlog();
    }
}
