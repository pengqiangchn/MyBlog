using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models.DTO
{
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
