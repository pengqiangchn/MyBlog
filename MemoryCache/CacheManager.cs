using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MemoryCache
{
    public static class CacheManager
    {
        private const int SLIDINGTIME = 30;
        private const int ABSOLUTETIME = 60;

        private static IMemoryCache _cache;
        private static IConfiguration _config;

        /// <summary>
        /// 可调过期时间 默认30秒
        /// </summary>
        private static TimeSpan _SlidingTime = TimeSpan.FromSeconds(SLIDINGTIME);

        /// <summary>
        /// 绝对过期时间 默认60秒
        /// </summary>
        private static TimeSpan _AbsoluteTime = TimeSpan.FromSeconds(ABSOLUTETIME);

        internal static void SetMemoryCache(IMemoryCache memoryCache, IConfiguration configuration)
        {
            _cache = memoryCache;
            _config = configuration;

            InitCacheOption();
        }

        private static void InitCacheOption()
        {
            _SlidingTime = TimeSpan.FromSeconds(
                                _config.GetValue("MemoryCache:SlidingTime", SLIDINGTIME)
                                );

            _AbsoluteTime = TimeSpan.FromSeconds(
                                _config.GetValue("MemoryCache:AbsoluteTime", ABSOLUTETIME)
                                );
        }

        /// <summary>
        /// 获取所有缓存键
        /// </summary>
        /// <returns></returns>
        private static List<string> GetCacheKeys()
        {
            const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            var entries = _cache.GetType().GetField("_entries", flags).GetValue(_cache);
            var cacheItems = entries as IDictionary;

            var keys = new List<string>();
            if (cacheItems == null) return keys;
            foreach (DictionaryEntry cacheItem in cacheItems)
            {
                keys.Add(cacheItem.Key.ToString());
            }
            return keys;
        }

        /// <summary>
        /// 所有缓存键值集合
        /// </summary>
        public static List<string> Keys
        {
            get
            {
                return GetCacheKeys();
            }
        }

        /// <summary>
        /// 缓存项总数
        /// </summary>
        public static int CacheCount
        {
            get
            {
                return Keys.Count();
            }
        }

        /// <summary>
        /// 验证缓存项是否存在
        /// </summary>
        /// <param name="key">缓存Key</param>
        /// <returns></returns>
        public static bool Exists(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));
            return _cache.TryGetValue(key, out _);
        }

        /// <summary>
        /// 设置缓存项
        /// 默认使用Config文件MemoryCache设置的时间
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="key"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static TItem AddOrSet<TItem>(string key, Func<MemoryCacheEntryOptions, TItem> factory)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            var Options = new MemoryCacheEntryOptions
            {
                SlidingExpiration = _SlidingTime,
                AbsoluteExpirationRelativeToNow = _AbsoluteTime
            };

            TItem item = _cache.Set(key, factory(Options), Options);

            return item;
        }

        /// <summary>
        /// 获取缓存项
        /// 如果为空值时,会带出默认值,如果需要判断空,请使用Exists方法
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TItem Get<TItem>(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            TItem item = _cache.Get<TItem>(key);

            return item;
        }

        /// <summary>
        /// 获取缓存项,如果不存在则创建新的缓存项
        /// 默认使用Config文件MemoryCache设置的时间
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="key"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static TItem GetOrAdd<TItem>(string key, Func<ICacheEntry, TItem> factory)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            TItem item = _cache.GetOrCreate(key, entry =>
            {
                entry.SlidingExpiration = _SlidingTime;
                entry.AbsoluteExpirationRelativeToNow = _AbsoluteTime;

                return factory(entry);
            });

            return item;
        }

        /// <summary>
        /// 获取缓存集合
        /// </summary>
        /// <param name="keys">缓存Key集合</param>
        /// <returns></returns>
        public static IDictionary<string, object> GetItems(IEnumerable<string> keys)
        {
            if (keys == null)
                throw new ArgumentNullException(nameof(keys));

            var dict = new Dictionary<string, object>();
            keys.ToList().ForEach(item => dict.Add(item, _cache.Get(item)));

            return dict;
        }

        /// <summary>
        /// 获取缓存集合
        /// </summary>
        /// <param name="keys">缓存Key集合</param>
        /// <returns></returns>
        public static IDictionary<string, TItem> GetItems<TItem>(IEnumerable<string> keys)
        {
            if (keys == null)
                throw new ArgumentNullException(nameof(keys));

            var dict = new Dictionary<string, TItem>();
            keys.ToList().ForEach(item => dict.Add(item, _cache.Get<TItem>(item)));

            return dict;
        }


        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key">缓存Key</param>
        /// <returns></returns>
        public static void Clear(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            _cache.Remove(key);
        }


        /// <summary>
        /// 删除匹配缓存项缓存
        /// </summary>
        public static void ClearItems(IEnumerable<string> keys)
        {
            if (keys == null)
                throw new ArgumentNullException(nameof(keys));

            keys.ToList().ForEach(item => _cache.Remove(item));
        }

        /// <summary>
        /// 删除所有缓存
        /// </summary>
        public static void ClearAll()
        {
            List<string> keys = GetCacheKeys();

            keys.ToList().ForEach(item => _cache.Remove(item));
        }

    }
}
