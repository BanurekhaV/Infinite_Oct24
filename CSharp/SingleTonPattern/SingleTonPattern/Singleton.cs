using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    public sealed class Singleton
    {
        //variable that will be incremented by 1 each time an object is created
        private static int counter = 0;

        //create a object that stores the Singleton instance
        private static Singleton sobj = null;

        //public static methods
        public static Singleton GetInstance()
        {
            if(sobj == null)
            {
                sobj = new Singleton();
            }
            return sobj;
        }

        //private parameterless constructor
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value is " + counter.ToString());
        }

        public void ShowDetails(string message)
        {
            Console.WriteLine(message);
        }

        //public class Derived : Singleton
        //{
            
        //}
    }

    
}
