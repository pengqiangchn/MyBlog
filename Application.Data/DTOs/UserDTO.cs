using Domain.Modules.BlogEntitys;
using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public BlogInfoDTO BlogInfoDTO { get; set; }

    }
}
