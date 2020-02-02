using Application.Services.Interfaces;
using Domain.Modules.BlogAgg;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class BlogAppService : IBlogAppService
    {
        private readonly IBlogDomainService _blogDomainService;

        public BlogAppService(IBlogDomainService blogDomainService)
        {
            _blogDomainService = blogDomainService;
        }

        public IList<Blog> GetAllBlog()
        {
            var ss = _blogDomainService.GetAllBlog();

            return ss;
        }
    }
}
