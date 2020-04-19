using Application.Data.DTOs;
using Application.Seedwork;
using Domain.Modules.BlogEntitys;
using MemoryCache;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {

        }

        public IActionResult Index()
        {
            string userKey = CacheKey.GetUserKey("Admin");
            UserDTO dto = CacheManager.Get<UserDTO>(userKey);


            if (dto == null)
            {
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                ViewBag.User = dto;
            }

            return View(dto);
        }
    }
}
