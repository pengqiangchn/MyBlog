
using Application.Data.DTOs;
using Domain.Modules.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IBlogClassAppService
    {
        Task<ClassInfoDTO> GetClass(Guid Id);

        /// <summary>
        /// 根据博客ID获取分类列表
        /// </summary>
        /// <param name="BlogId"></param>
        /// <returns></returns>
        List<ClassInfoDTO> GetClassListByBlogId(Guid BlogId);

        void AddClass(ClassInfoDTO classDTO);

        Task<BlogClass> AddClassAsync(ClassInfoDTO classDTO);

        Task<List<ClassListDTO>> GetClassList(Guid blogId);
    }
}
