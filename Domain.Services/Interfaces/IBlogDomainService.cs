﻿using Domain.Modules.BlogEntitys;
using Domain.Seedwork.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Interfaces
{
    public interface IBlogDomainService : IDomainService<BlogInfo>
    {
        List<BlogInfo> GetAllBlog();
    }
}
