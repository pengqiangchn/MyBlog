using Domain.Modules.BlogAgg;
using Domain.Seedwork.Common;
using Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Services
{
    public class BlogDomainService : DomainService<Blog>, IBlogDomainService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogDomainService(IBlogRepository blogRepository)
            : base(blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<Blog> GetAllBlog()
        {
            List<Blog> list = GetAll().ToList();

            return list;
        }

    }
}
