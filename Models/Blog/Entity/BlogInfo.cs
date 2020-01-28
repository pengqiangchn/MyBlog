using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models.Blog.Entity
{
    public class BlogInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        [Key]
        public string BlogId { get; set; }

        /// <summary>
        /// 博客名
        /// </summary>
        [Column(TypeName = "varchar(128)")]
        public string BlogName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string UserId { get; set; }

    }
}
