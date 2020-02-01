using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Seedwork
{
    public abstract class AuditableEntity : Entity, IAuditableEntity
    {
        /// <summary>
        /// 创建人
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastModifiedAt { get; set; }
    }
}
