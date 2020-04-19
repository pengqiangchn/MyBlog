using Domain.Modules.BlogAggs;
using Domain.Modules.BlogEntitys;
using Domain.Seedwork.Common;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class ClassDomainService : DomainService<BlogClass>, IClassDomainService
    {
        private readonly IBlogClassRepository _clsssRepository;

        public ClassDomainService(IBlogClassRepository clsssRepository)
            : base(clsssRepository)
        {
            _clsssRepository = clsssRepository;
        }

        //public List<BlogClass> GetClassList(Guid blogId)
        //{
        //    var list = _clsssRepository.GetClassList(blogId);


        //    return list;
        //}

    }
}
