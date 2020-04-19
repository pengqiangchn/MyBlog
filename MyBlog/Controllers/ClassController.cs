using Application.Data.DTOs;
using Application.Seedwork;
using Application.Services.Interfaces;
using MemoryCache;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    public class ClassController : Controller
    {
        private readonly IBlogClassAppService _classAS;

        public ClassController(IBlogClassAppService classAS)
        {
            _classAS = classAS;
        }

        [Route("Class")]
        [Route("Class/List")]
        public IActionResult List()
        {
            Guid blogId = CacheManager.Get<UserDTO>(CacheKey.GetUserKey("Admin"))?.BlogInfoDTO.Id ?? Guid.Empty;

            List<ClassInfoDTO> dtoList = _classAS.GetClassListByBlogId(blogId);

            return View(dtoList);
        }

        public IActionResult Create()
        {
            //var dto = new ClassInfoDTO { };


            return View(new ClassInfoDTO());
        }


        [HttpPost]
        public async Task<IActionResult> Create(ClassInfoDTO classInfo)
        {
            classInfo.BlogId = CacheManager.Get<UserDTO>(CacheKey.GetUserKey("Admin"))?.BlogInfoDTO.Id ?? Guid.Empty;

            if (ModelState.IsValid)
            {
                var ss = await _classAS.AddClassAsync(classInfo);

                return RedirectToAction("Index");
            }

            return View(classInfo);

        }






    }
}
