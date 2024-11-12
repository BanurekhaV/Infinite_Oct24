using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day12_Dotnet
{
    class SinglethreadEg
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;

            t.Name = "MyMain Thread";
            Console.WriteLine("Current executing thread :" + t.Name);
            Console.WriteLine("Current thread is " + Thread.CurrentThread.Name);

            Method1();
            Method2();
            Method3();
            Console.Read();
        }

        static void Method1()
        {
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine("Method 1 : " + i);
            }
        }

        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2 : " + i);

                //code to see the drawbacks of single thread
                if(i==3)
                {
                    Console.WriteLine("Starting to Perform Database Operations...");
                    //put the thread to sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Database Operations Completed....");
                }
            }
        }

        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3 : " + i);
            }
        }
    }
}
