﻿
using Domain.Modules.BlogEntitys;
using System;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface IBlogInfoAppService
    {
        IList<BlogInfo> GetAllBlog();
    }
}
