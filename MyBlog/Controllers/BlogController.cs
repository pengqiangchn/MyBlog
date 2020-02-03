using System;
using System.Collections.Generic;
using System.Linq;
using Application.DTOs;
using Application.Seedwork;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Modules.BlogInfoAgg;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogInfoAppService _blogInfoAppService;

        public BlogController(IBlogInfoAppService blogInfoAppService)
        {
            _blogInfoAppService = blogInfoAppService;
        }

        public IActionResult Index()
        {
            BlogInfo info = _blogInfoAppService.GetAllBlog().First();

            IndexInfoDto dto = new IndexInfoDto();
            dto.BlogInfo = info.MapTo<BlogInfoDto>();
            BriefIntroductionDto brief = new BriefIntroductionDto();
            brief.Title = "测试";
            dto.BriefIntroductionList = new List<BriefIntroductionDto>();
            dto.BriefIntroductionList.Add(brief);

            dto.BriefIntroductionList.Add(new BriefIntroductionDto() { Title = "测试2" });

            return View(dto);
        }

        public JsonResult Test()
        {
            BlogInfo blog = new BlogInfo()
            {
                BlogId = "223",
                BlogName = "Test"
            };

            ////bs.MapTo<ClassInfoDto>();

            //ClassInfoDto dto = _map.Map<ClassInfoDto>(bs);

            BlogInfoDto dto = blog.MapTo<BlogInfoDto>(); ;

            return Json(dto);

        }

    }
}