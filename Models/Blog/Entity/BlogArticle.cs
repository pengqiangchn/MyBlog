using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models.Blog.Entity
{
    /// <summary>
    /// 文章类
    /// </summary>
    public class BlogArticle
    {
        /// <summary>
        /// 文章Id
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        [Key]
        public string ArticleId { get; set; }

        /// <summary>
        /// 博客Id
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string BlogId { get; set; }

        /// <summary>
        /// 分类Id
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string ClassId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime EditTime { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [Column(TypeName = "varchar(128)")]
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>        
        public string Content { get; set; }

        /// <summary>
        /// 阅读次数
        /// </summary>
        public int ReadCount { get; set; }

        /// <summary>
        /// 收藏次数
        /// </summary>
        public int PraiseCount { get; set; }

    }
}
