using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.DTO.Blog
{
    /// <summary>
    /// 分类显示
    /// </summary>
    public class ClassFileDto
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount
        {
            get
            {
                return ClassInfoList.Sum(c => c.Count);
            }
        }

        /// <summary>
        /// 分类信息
        /// </summary>

        public List<ClassInfoDto> ClassInfoList { get; set; }
    }
}
