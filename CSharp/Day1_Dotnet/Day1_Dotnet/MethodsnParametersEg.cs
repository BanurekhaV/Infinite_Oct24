using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Dotnet
{
    class MethodsnParametersEg
    {
        public static void SimpleMethod(int num)  
        {
            num = 100;
            Console.WriteLine("value of num " + num);
        }

        public static void SimpleMethod2(ref int num)
        {
            num = 100;
            Console.WriteLine("value of num " + num);
        }
    }

    class Driver
    {
        public static void Main()
        {
            int i = 10;
            MethodsnParametersEg.SimpleMethod(i);  //by value
            Console.WriteLine("value of i " + i);
            MethodsnParametersEg.SimpleMethod2(ref i); // by reference
            Console.WriteLine("value of i " + i);            
            Console.Read();
        }
    }
}
