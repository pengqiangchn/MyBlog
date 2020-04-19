using System;
using System.Collections.Generic;
using System.Linq;
using Application.Data.DTOs;
using Application.Seedwork;
using Application.Services.Interfaces;
using Domain.Modules.BlogEntitys;
using MemoryCache;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Enum;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogInfoAppService _blogInfoAppService;
        private readonly IBlogUserAppService _blogUserAppService;

        public BlogController(IBlogInfoAppService blogInfoAppService,
            IBlogUserAppService blogUserAppService)
        {
            _blogInfoAppService = blogInfoAppService;
            _blogUserAppService = blogUserAppService;
        }

        public IActionResult Index()
        {
            //var ss = CacheManager.AddOrSet

            BlogInfo info = _blogInfoAppService.GetAllBlog().First();

            IndexInfoDTO dto = new IndexInfoDTO();
            dto.BlogInfo = info.MapTo<BlogInfoDTO>();
            BriefIntroductionDto brief = new BriefIntroductionDto();
            brief.Title = "测试";
            dto.BriefIntroductionList = new List<BriefIntroductionDto>();
            dto.BriefIntroductionList.Add(brief);

            dto.BriefIntroductionList.Add(new BriefIntroductionDto() { Title = "测试2" });


            //UserDTO user = _blogUserAppService.GetUser(Guid.Parse("00000001-0000-0000-0000-000000000000"));
            SetAdminUser();

            return View(dto);
        }

        /// <summary>
        /// 当作登录了
        /// </summary>
        private void SetAdminUser()
        {
            //BlogUser blogUser = new BlogUser
            //{
            //    UserName = "Admin",
            //    Id = Guid.Parse("00000001-0000-0000-0000-000000000000")
            //};

            UserDTO blogUser = _blogUserAppService.GetUser("Admin");

            CacheManager.AddOrSet(CacheKey.GetUserKey("Admin"), x => blogUser);
        }


        public JsonResult Test()
        {
            //BlogInfo blog = new BlogInfo()
            //{
            //    Id = Guid.NewGuid(),
            //    BlogName = "Test"
            //};

            ////bs.MapTo<ClassInfoDto>();

            //ClassInfoDto dto = _map.Map<ClassInfoDto>(bs);

            //BlogInfoDTO dto = blog.MapTo<BlogInfoDTO>(); ;


            UserDTO dto = _blogUserAppService.GetUser(Guid.Parse("00000001-0000-0000-0000-000000000000"));

            return Json(dto);

        }

    }
}