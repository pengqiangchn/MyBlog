using System;
using System.Collections.Generic;
using System.Linq;
using Application.DTO;
using Application.Seedwork;
using AutoMapper;
using Domain.Modules.BlogAgg;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Context;
using MyBlog.Models.DTO;
using MyBlog.Models.Entity;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly UnitOfWork _context;
        private readonly IMapper _map;

        public BlogController(UnitOfWork context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public IActionResult Index()
        {
            //BlogInfo info = _context.BlogInfo.First();
            IndexInfoDto dto = new IndexInfoDto();
            //dto.BlogInfo = _map.Map<BlogInfoDto>(info);
            //BriefIntroductionDto brief = new BriefIntroductionDto();
            //brief.Title = "测试";
            //dto.BriefIntroductionList = new List<BriefIntroductionDto>();
            //dto.BriefIntroductionList.Add(brief);

            //dto.BriefIntroductionList.Add(new BriefIntroductionDto() { Title = "测试2" });


            return View(dto);
        }

        public JsonResult Test()
        {
            Blog blog = new Blog()
            {
                BlogId = "223",
                BlogName = "Test"
            };

            ////bs.MapTo<ClassInfoDto>();

            //ClassInfoDto dto = _map.Map<ClassInfoDto>(bs);

            BlogDTO dto = blog.MapTo<BlogDTO>(); ;

            return Json(dto);

        }

    }
}