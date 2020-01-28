using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models.Blog.Entity
{
    public class BlogClass
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        [Key]
        public string ClassId { get; set; }

        /// <summary>
        /// 博客Id
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string BlogId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string ClassName { get; set; }

        /// <summary>
        /// 上级分类
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string ParentId { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }

    }
}
