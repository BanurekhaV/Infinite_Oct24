using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day12_Dotnet
{
    class MultiThreadEg
    {
        static void Main()
        {
            Console.WriteLine("Main Thread Started...");

            //creating threads
            Thread t1 = new Thread(Method1) //nternally invokes the threadstart delegate object
            {
                Name = "Thread 1"
            };

            Thread t2 = new Thread(Method2)
            {
                Name = "Thread 2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread 3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ending ....");
            Console.Read();

        }
        static void Method1()
        {
            Console.WriteLine("Method 1 started... using .. " + Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 1 : " + i);
            }
            Console.WriteLine("Method 1 ended... using .. " + Thread.CurrentThread.Name);
        }

        static void Method2()
        {
            Console.WriteLine("Method 2 started... using .. " + Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2 : " + i);

                //code to see the drawbacks of single thread
                if (i == 3)
                {
                    Console.WriteLine("Starting to Perform Database Operations...");
                    //put the thread to sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Database Operations Completed....");
                }
            }
            Console.WriteLine("Method 2 ended... using .. " + Thread.CurrentThread.Name);
        }

        static void Method3()
        {
            Console.WriteLine("Method 3 started... using .. " + Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3 : " + i);
            }
            Console.WriteLine("Method 3 ended... using .. " + Thread.CurrentThread.Name);
        }
    }
}
