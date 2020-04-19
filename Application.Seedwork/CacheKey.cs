using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Seedwork
{
    public static class CacheKey
    {
        /// <summary>
        /// 根据枚举获取Key值
        /// </summary>
        /// <param name="cacheEnum"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string GetKey(CacheEnum cacheEnum, string key)
        {
            return $"{ cacheEnum.ToString()}-{key}";
        }

        /// <summary>
        /// 获取用户CacheKey
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static string GetUserKey(string userName)
        {
            return GetKey(CacheEnum.UserId, userName);
        }

    }
}
