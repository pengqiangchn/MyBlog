using Domain.Modules.BlogAggs;
using Domain.Modules.BlogEntitys;
using Domain.Seedwork.Common;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class UserDomainService : DomainService<BlogUser>, IUserDomainService
    {
        private readonly IBlogUserRepository _userRepository;

        public UserDomainService(IBlogUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public BlogUser GetUserbyName(string userName)
        {
            return _userRepository.GetUserbyName(userName);
        }
    }
}
