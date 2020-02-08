using AutoMapper;
using Domain.Modules.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs.Profiles
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            CreateMap<BlogUser, UserDTO>()
                .ForMember(d => d.BlogInfoDTO, o => o.MapFrom(s => s.BlogInfo));


            CreateMap<BlogInfo, BlogInfoDTO>();
        }
    }
}
