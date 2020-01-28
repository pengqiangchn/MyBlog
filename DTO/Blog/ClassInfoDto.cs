using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.DTO.Blog
{
    public class ClassInfoDto
    {
        public string ClassId { get; set; }

        public string ClassName { get; set; }

        public string ParentId { get; set; }

        public int Level { get; set; }

        public int Count { get; set; }
    }
}
