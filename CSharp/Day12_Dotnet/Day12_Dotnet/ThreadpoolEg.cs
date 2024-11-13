using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day12_Dotnet
{
    class ThreadpoolEg
    {
        static void Main()
        {
            //with Thread pool
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(OurMethod));
            }

            //without ThreadPool
            //for (int i = 0; i <= 10; i++)
            //{
            //    Thread thread = new Thread(OurMethod)
            //    {
            //        Name = "Thread " + i,
            //    };
            //    thread.Start();
            //}
            Console.Read();
        }

        public static void OurMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $" Thread Name : {thread.Name}  Background : {thread.IsBackground},  Thread Pool ? : {thread.IsThreadPoolThread}," +
                $" Thread ID : {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
