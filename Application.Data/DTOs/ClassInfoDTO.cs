using Application.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Data.DTOs
{
    public class ClassInfoDTO : DTO
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [Required]
        public string ClassName { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 排序ID
        /// </summary>
        [DisplayName("序号")]
        public string OrderId { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 博客Id
        /// </summary>
        public Guid BlogId { get; set; }

        /// <summary>
        /// 文章数量
        /// </summary>
        public int Count { get; set; }
    }
}
