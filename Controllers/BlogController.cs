using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "This is Blog Ttest Index Action";
        }

        public string Hello(string name, int id)
        {
            return $"This is Blog Hello Function Name {name } ID {id}";
        }

    }
}