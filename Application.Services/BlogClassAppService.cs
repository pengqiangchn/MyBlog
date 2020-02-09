using Application.DTOs;
using Application.Seedwork;
using Application.Services.Interfaces;
using Domain.Modules.BlogEntitys;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services
{
    public class BlogClassAppService : IBlogClassAppService
    {
        private readonly IClassDomainService _classDS;

        public BlogClassAppService(IClassDomainService classDS)
        {
            _classDS = classDS;
        }

        public List<ClassInfoDTO> GetClassListByBlogId(Guid BlogId)
        {
            List<BlogClass> classes = _classDS.GetFiltered(x => x.BlogId == BlogId).ToList();

            var dtos = classes.MapToCollection<ClassInfoDTO>();


            return dtos;
        }
    }
}
