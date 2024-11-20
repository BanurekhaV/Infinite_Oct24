using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //first time instantiation
            Singleton obj1 = Singleton.GetInstance();
            obj1.ShowDetails("This is a message from Object 1");

            //second time instantiation

            Singleton obj2 = Singleton.GetInstance();
            obj2.ShowDetails("This is a message from Object 2");

            //creating more objects of singleton class by making use of inner class
            Singleton.Derived dobj = new Singleton.Derived();
            dobj.ShowDetails("This is bypassed object..");
            Console.Read();
        }
    }
}
