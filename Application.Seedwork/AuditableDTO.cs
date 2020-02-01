﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Seedwork
{
    public abstract class AuditableDTO : DTO
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}
