using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyBlog.Models.DTO
{
    public class ArticleFileDto
    {
        /// <summary>
        /// 年份
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }
    }
}
