using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonPattern;


namespace Singleton_Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton Client2 = Singleton.GetInstance();
            Client2.ShowDetails("This Client 2 first request to the single ton object");
            Console.Read();
        }
    }
}
