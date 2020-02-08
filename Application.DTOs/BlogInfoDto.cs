using Domain.Modules.BlogEntitys;
using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    [AutoInject(typeof(BlogInfo))]
    public class BlogInfoDTO
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 博客名
        /// </summary>
        public string BlogName { get; set; }
    }
}
