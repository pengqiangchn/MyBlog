using AutoMapper;
using MyBlog.DTO.Blog;
using MyBlog.Models.Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Profiles
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            CreateMap<BlogInfo, BlogInfoDto>();

            CreateMap<BlogClass, ClassInfoDto>();

            CreateMap<BlogArticle, BriefIntroductionDto>();
        }
    }
}
