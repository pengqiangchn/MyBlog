using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Context;
using MyBlog.Models.DTO;
using MyBlog.Models.Entity;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly MyBlogContext _context;
        private readonly IMapper _map;

        public BlogController(MyBlogContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public IActionResult Index()
        {
            BlogInfo info = _context.BlogInfo.First();
            IndexInfoDto dto = new IndexInfoDto();
            dto.BlogInfo = _map.Map<BlogInfoDto>(info);
            BriefIntroductionDto brief = new BriefIntroductionDto();
            brief.Title = "测试";
            dto.BriefIntroductionList = new List<BriefIntroductionDto>();
            dto.BriefIntroductionList.Add(brief);

            dto.BriefIntroductionList.Add(new BriefIntroductionDto() { Title = "测试2" });


            return View(dto);
        }

        public JsonResult Test()
        {
            BlogClass bs = new BlogClass()
            {
                ClassId = "123",
                BlogId = "223",
                ClassName = "Test",
                ParentId = "333",
                Level = 1
            };

            //bs.MapTo<ClassInfoDto>();

            ClassInfoDto dto = _map.Map<ClassInfoDto>(bs);

            return Json(dto);

        }

    }
}