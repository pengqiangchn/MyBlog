using System;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Context;
using MyBlog.DTO.Blog;
using MyBlog.Models.Blog.Entity;

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

            ClassInfoDto dto = _map.Map<ClassInfoDto>(bs);

            return Json(dto);

        }

    }
}