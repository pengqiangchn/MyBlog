using Domain.Modules.BlogAggs;
using Domain.Modules.BlogEntitys;
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

        public BlogInfo GetBlogById(Guid id)
        {
            return _blogRepository.Get(id);
        }

        public List<BlogInfo> GetBloginfo()
        {
            var list = GetFiltered(b => b.BlogName.Contains("MyBlog")).ToList();

            return list;
        }

    }
}
