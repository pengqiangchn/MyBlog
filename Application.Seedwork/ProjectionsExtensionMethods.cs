using AutoMapper;
using Domain.Seedwork;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Application.Seedwork
{
    public static class ProjectionsExtensionMethods
    {
        static IMapper _mapper;

        public static void UseAutoMapper(this IApplicationBuilder applicationBuilder)
        {
            _mapper = applicationBuilder.ApplicationServices.GetRequiredService<IMapper>();
        }

        public static TProjection MapTo<TProjection>(this Entity item)
            where TProjection : class, new()
        {
            return _mapper.Map<TProjection>(item);
        }

        public static List<TProjection> MapToCollection<TProjection>(this IEnumerable<Entity> items)
            where TProjection : class, new()
        {
            return _mapper.Map<List<TProjection>>(items);
        }
    }
}
