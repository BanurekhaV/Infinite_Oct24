using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Caching
{
    public sealed class SingletonCache : IMyCache
    {
        //As shared resources have to be protected in a multithteaded environment,
        // we can use ConcurrentDictionary collection which thread safe

        private ConcurrentDictionary<object, object> cd = new ConcurrentDictionary<object, object>();

        //object for storing singleton instance
        private static readonly SingletonCache singleinstance = new SingletonCache();

        //private constructor
        private SingletonCache()
        {
            Console.WriteLine("Singleton Instance Created..");
        }

        //provide static method for instantiation, and return the singleton object

        public static SingletonCache GetInstance()
        {
            return singleinstance;
        }

        // this method will add a key with value into the cache
        public bool Add(object key, object value)
        {
            return cd.TryAdd(key, value);
        }

        //this method will check for the avialabilty of the key. If found, performs update,
        //else adds a key with value
        public bool AddOrUpdate(object key, object value)
        {
            if(cd.ContainsKey(key))
            {
                cd.TryRemove(key, out object removeddata);
            }
            return cd.TryAdd(key, value);
        }

        public void Clear()
        {
            cd.Clear();
        }

        //this method will return a value of a specified key if found, else returns null
        public object Get(object key)
        {
            if(cd.ContainsKey(key))
            {
                return cd[key];
            }
            return null;
        }

        //tjis method will remove the key from the cache
        public bool Remove(object key)
        {
            return cd.TryRemove(key, out object removedval);
        }
    }
}
