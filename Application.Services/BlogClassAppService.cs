using Application.Data.DTOs;
using Application.Seedwork;
using Application.Services.Interfaces;
using Domain.Modules.BlogEntitys;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BlogClassAppService : IBlogClassAppService
    {
        private readonly IClassDomainService _classDS;

        public BlogClassAppService(IClassDomainService classDS)
        {
            _classDS = classDS;
        }

        public async Task<ClassInfoDTO> GetClass(Guid Id)
        {
            var blogClass = await _classDS.GetAsync(Id);

            var dto = blogClass.MapTo<ClassInfoDTO>();
            //var dto = blogClass.Result.MapTo<ClassInfoDTO>();

            return dto;
        }


        public List<ClassInfoDTO> GetClassListByBlogId(Guid BlogId)
        {
            List<BlogClass> classes = _classDS.GetFiltered(x => x.BlogId == BlogId).OrderBy(x => x.OrderID).ToList();

            var dtos = classes.MapToCollection<ClassInfoDTO>();


            return dtos;
        }

        public void AddClass(ClassInfoDTO classDTO)
        {
            BlogClass blogClass = classDTO.MapTo<BlogClass>();

            _classDS.Add(blogClass);
        }

        public async Task<BlogClass> AddClassAsync(ClassInfoDTO classDTO)
        {
            BlogClass blogClass = classDTO.MapTo<BlogClass>();
            blogClass.GenerateNewIdentity();

            return await _classDS.AddAsync(blogClass);

        }

        public async Task<List<ClassListDTO>> GetClassList(Guid blogId)
        {
            IEnumerable<BlogClass> classes = await _classDS.GetFilteredAsync(x => x.BlogId == blogId);

            ClassListDTO emptyDto = new ClassListDTO { Id = null };
            SetClassDtoChildren(emptyDto, classes.ToList());
            //classList.


            return emptyDto.Children;
        }

        private void SetClassDtoChildren(ClassListDTO dto, IEnumerable<BlogClass> list)
        {
            var children = list.Where(c => c.ParentId == dto.Id);

            if (children.Any())
            {
                var childrenDto = children.MapToCollection<ClassListDTO>();
                dto.Children = childrenDto;
                foreach (var child in childrenDto)
                {
                    SetClassDtoChildren(child, list);
                }
            }
        }

    }
}
