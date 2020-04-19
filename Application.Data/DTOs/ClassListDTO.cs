using Application.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Data.DTOs
{
    public class ClassListDTO : DTO
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 排序ID
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 博客Id
        /// </summary>
        public Guid BlogId { get; set; }

        /// <summary>
        /// 文章数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 子集数据
        /// </summary>
        public List<ClassListDTO> Children { get; set; }
    }
}
