using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryCache
{
    public static class CacheManagerExtensions
    {
        public static void UseCacheManager(this IApplicationBuilder builder)
        {
            CacheManager.SetMemoryCache(
                builder.ApplicationServices.GetRequiredService<IMemoryCache>(),
                builder.ApplicationServices.GetRequiredService<IConfiguration>()
                );
        }
    }
}
