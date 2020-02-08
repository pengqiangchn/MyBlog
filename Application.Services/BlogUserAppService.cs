using Application.DTOs;
using Application.Seedwork;
using Application.Services.Interfaces;
using Domain.Modules.BlogEntitys;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class BlogUserAppService : IBlogUserAppService
    {
        private readonly IUserDomainService _userDomainService;

        public BlogUserAppService(IUserDomainService userDomainService)
        {
            _userDomainService = userDomainService;
        }

        public UserDTO GetUser(Guid id)
        {
            var user = _userDomainService.Get(id);

            var dto = user.MapTo<UserDTO>();


            return dto;
        }
    }
}
