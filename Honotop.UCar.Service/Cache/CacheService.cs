using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Service.Cache
{
  public  class CacheService: ICacheService
    {
        protected ObjectCache Cache
        {
            get
            {
                return MemoryCache.Default;
            }
        }


        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        public T GetT<T>(string key, Func<T> action, int cacheMinutesTime)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException("错误：key值为空");

            bool isExist = Cache.Contains(key);
            if (isExist)
                return (T)Cache[key];

            var data = action();
            if (data != null)
                Set(key, data, cacheMinutesTime);
            return data;
            
        }

        public void Set(string key, object data, int cacheMinutesTime)
        {
            if (data == null)
                return;

            var policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheMinutesTime);
            Cache.Add(new CacheItem(key, data), policy);
        }

        public bool IsSet(string key)
        {
            return (Cache.Contains(key));
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }

        public void Clear()
        {
            foreach (var item in Cache)
                Remove(item.Key);
        }
    }
}
