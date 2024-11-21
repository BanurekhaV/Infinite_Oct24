using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Caching
{
    public interface IMyCache
    {
        bool Add(object key, object value);
        bool AddOrUpdate(object key, object value);
        object Get(object key);
        bool Remove(object key);
        void Clear();
    }
}
