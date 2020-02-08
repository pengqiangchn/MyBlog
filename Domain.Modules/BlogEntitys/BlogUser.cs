using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Modules.BlogEntitys
{
    public class BlogUser : EntityGuid
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string PassWord { get; set; }

        /// <summary>
        /// 博客
        /// </summary>
        public virtual BlogInfo BlogInfo { get; set; }

    }
}
