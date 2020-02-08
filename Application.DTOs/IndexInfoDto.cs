using Domain.Modules.BlogEntitys;
using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class IndexInfoDTO
    {
        /// <summary>
        /// 博客信息
        /// </summary>
        public BlogInfoDTO BlogInfo { get; set; }

        /// <summary>
        /// 文章归档信息
        /// </summary>
        public List<ArticleFileDTO> ArticleFileList { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public List<BriefIntroductionDto> BriefIntroductionList { get; set; }

        /// <summary>
        /// 分类归档信息
        /// </summary>
        public List<ClassFileDTO> ClassFileList { get; set; }


    }
}
