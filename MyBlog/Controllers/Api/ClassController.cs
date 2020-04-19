using Application.Data.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IBlogClassAppService _classAS;

        public ClassController(IBlogClassAppService classAS)
        {
            _classAS = classAS;
        }


        // GET: api/Class/Id    //查询单个
        [HttpGet("{id}")]
        //[HttpGet]
        public async Task<ActionResult<ClassInfoDTO>> GetClass(Guid Id)
        {
            var list = await _classAS.GetClass(Id);

            return list;
        }

        // GET: api/Class?blogId = "" 查询条件
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassListDTO>>> GetClassList(Guid blogId)
        {
            var list = await _classAS.GetClassList(blogId);

            return list;
        }
    }
}
