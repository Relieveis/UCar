using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Service.Cache
{
    public interface ICacheService
    {
        T Get<T>(string key);
        T GetT<T>(string key, Func<T> action, int cacheMinutesTime);
        void Set(string key, object data, int cacheMinutesTime);
        bool IsSet(string key);
        void Remove(string key);
        void Clear();
    }
}
