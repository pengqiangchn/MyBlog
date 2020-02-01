using Domain.Modules.BlogAgg;
using System;
using System.Collections.Generic;

namespace Application.Services.Interface
{
    interface IBlogAppService
    {
        IList<Blog> GetAllBlog();
    }
}
