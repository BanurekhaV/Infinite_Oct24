using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Caching
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //obtaining singleton object
            SingletonCache cache = SingletonCache.GetInstance();

            //1.add some data to the cache 
            Console.WriteLine("Adding Keys and Values to the Cache..");
            Console.WriteLine($"Adding Eid in cache :{cache.Add("EID", 101)}");
            Console.WriteLine($"Adding Name of the Employee to Cache :{cache.Add("EName", "Mridula")}");

            Console.WriteLine($"Adding Eid in cache :{cache.Add("EID", 102)}");
            Console.WriteLine($"Adding Name of the Employee to Cache :{cache.Add("EName", "Mahesh")}");
            Console.WriteLine($"Adding the same ID to the cache using addorupdate : {cache.AddOrUpdate("EID", 102)}");
            //2. Retrieve data from cache
            Console.WriteLine("Fetching Data from cache-----");
            Console.WriteLine($"Getting EID from Cache : {cache.Get("EID")}");
            Console.WriteLine($"Getting Emp Name : {cache.Get("EName")}");

            //3. remove key

            Console.WriteLine("Removing Key from cache");

            Console.WriteLine($"Removing ID : {cache.Remove("EID")}");
            Console.WriteLine($"Getting EID from Cache : {cache.Get("EID")}");
            Console.Read();
        }
    }
}
