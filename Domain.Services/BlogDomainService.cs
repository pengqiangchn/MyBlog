using Domain.Modules.BlogClassAgg;
using Domain.Modules.BlogInfoAgg;
using Domain.Seedwork.Common;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Services
{
    public class BlogDomainService : DomainService<BlogInfo>, IBlogDomainService
    {
        private readonly IBlogInfoRepository _blogRepository;

        public BlogDomainService(IBlogInfoRepository blogRepository)
            : base(blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<BlogInfo> GetAllBlog()
        {
            var list = GetFiltered(b => b.BlogName.Contains("MyBlog")).ToList();

            return list;
        }

    }
}
