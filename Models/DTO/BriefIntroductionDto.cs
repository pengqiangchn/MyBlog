using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models.DTO
{
    public class BriefIntroductionDto
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsTop { get; set; }

    }
}
