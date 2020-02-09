
using Application.DTOs;
using Domain.Modules.BlogEntitys;
using System;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface IBlogClassAppService
    {
        /// <summary>
        /// 根据博客ID获取分类列表
        /// </summary>
        /// <param name="BlogId"></param>
        /// <returns></returns>
        List<ClassInfoDTO> GetClassListByBlogId(Guid BlogId);

    }
}
