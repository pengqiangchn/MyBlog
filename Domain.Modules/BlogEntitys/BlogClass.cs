using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Modules.BlogEntitys
{
    public class BlogClass : EntityGuid
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        [Required]
        public string ClassName { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [Column(TypeName = "varchar(12)")]
        public string OrderID { get; set; }

        /// <summary>
        /// 博客Id
        /// </summary>
        public Guid BlogId { get; set; }

        public virtual BlogInfo BlogInfo { get; set; }

        /// <summary>
        /// 上级分类
        /// </summary>        
        public Guid? ParentId { get; set; }

        //public virtual BlogClass ParentClass { get; set; }

        ///// <summary>
        ///// 下级分类
        ///// </summary>
        //public virtual List<BlogClass> Childrens { get; set; }

        /// <summary>
        /// 文章列表
        /// </summary>
        public virtual List<BlogArticle> Articles { get; set; }

    }
}
