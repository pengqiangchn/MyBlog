using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models.DTO
{
    public class ClassInfoDto
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public string ClassId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 文章数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 排序ID
        /// </summary>
        public string OrderId { get; set; }
    }
}
