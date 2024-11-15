using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class AysncnAwait
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i + "  Method  1");
                    //code to do something here 
                    Task.Delay(100).Wait();
                }
            }
            );
        }

        public static void Method2()
        {
            for(int i =0; i<20;i++)
            {
                Console.WriteLine("Method 2");
                //some code
                Task.Delay(100).Wait();
            }
        }

        static void Main()
        {
            Method1();
            Method2();
            Console.Read();
        }
    }
}
