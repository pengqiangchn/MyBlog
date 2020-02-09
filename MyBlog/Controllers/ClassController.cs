using Application.DTOs;
using Application.Services.Interfaces;
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
            List<ClassInfoDTO> dtoList = _classAS.GetClassListByBlogId(Guid.Parse(""));

            return View(dtoList);
        }
    }
}
