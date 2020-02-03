using Domain.Modules.BlogInfoAgg;
using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    [AutoInject(typeof(BlogInfo))]
    public class BlogInfoDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string BlogId { get; set; }

        /// <summary>
        /// 博客名
        /// </summary>
        public string BlogName { get; set; }
    }
}
