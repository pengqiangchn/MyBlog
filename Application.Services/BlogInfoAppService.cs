using Application.Services.Interfaces;
using Domain.Modules.BlogEntitys;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class BlogInfoAppService : IBlogInfoAppService
    {
        private readonly IBlogDomainService _blogDomainService;

        public BlogInfoAppService(IBlogDomainService blogDomainService)
        {
            _blogDomainService = blogDomainService;
        }

        public IList<BlogInfo> GetAllBlog()
        {
            var ss = _blogDomainService.GetAllBlog();

            return ss;
        }
    }
}
