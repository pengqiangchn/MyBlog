﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    public class ArticleController : Controller
    {
        public ArticleController()
        {

        }

        [Route("Index")]
        [Route("Article")]
        [Route("Article/List")]
        public IActionResult List()
        {
            return View();
        }
        /*
                public IActionResult ArticleList()
                {
                    return View();
                }

                public IActionResult ClassList()
                {
                    List<ClassInfoDto> dtoList = new List<ClassInfoDto>();
                    dtoList.Add(new ClassInfoDto()
                    {
                        ClassName = "测试1",
                        Count = 3,
                        OrderId = "1"
                    });
                    dtoList.Add(new ClassInfoDto()
                    {
                        ClassName = "测试2",
                        Count = 44,
                        OrderId = "2"
                    });

                    return View(dtoList);
                }
                */

    }
}
