using AutoMapper;
using MyBlog.Models.DTO;
using MyBlog.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BlogInfo, BlogInfoDto>();

            CreateMap<BlogClass, ClassInfoDto>();

            CreateMap<BlogArticle, BriefIntroductionDto>();
        }
    }
}
