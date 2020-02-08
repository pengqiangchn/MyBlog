using Domain.Modules.BlogEntitys;
using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    //[AutoInject(typeof(BlogUser))]
    public class UserDTO
    {
        public string UserName { get; set; }

        public BlogInfoDTO BlogInfoDTO { get; set; }

    }
}
