
using Application.Data.DTOs;
using Domain.Modules.BlogEntitys;
using System;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface IBlogUserAppService
    {
        UserDTO GetUser(Guid id);

        UserDTO GetUser(string userName);


    }
}
