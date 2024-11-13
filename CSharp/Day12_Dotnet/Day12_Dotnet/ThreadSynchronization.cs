using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day12_Dotnet
{

    class ThreadSynchronization
    {
        public Thread t1, t2;
        public void DisplayNum()
        {
           lock (this)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("Running Thread = {0} ", Thread.CurrentThread.Name);
                }
            }
        }


        public static void Main()
        {
            Console.WriteLine("----Synchronization using Locks-----");
            //ThreadSynchronization ts = new ThreadSynchronization();
            //Console.WriteLine("Threading using Locks...");
            //ts.t1 = new Thread(new ThreadStart(ts.DisplayNum));
            //ts.t1.Name = "Thread 1";
            //ts.t2 = new Thread(new ThreadStart(ts.DisplayNum));
            //ts.t2.Name = "Thread 2";

            //ts.t1.Start();
            //ts.t2.Start();

            Console.WriteLine("----Synchronization using Joins-----");
            Thread tj1 = new Thread(JoinSynchronization.Function1);
           
            Thread tj2 = new Thread(JoinSynchronization.Function2);
           
            tj2.Start();
            tj1.Start();

            tj1.Join();
            tj2.Join();       
                     
            Console.Read();
        }
    }

    class JoinSynchronization
    {
       public static void Function1(Object obj)
        {
            Console.WriteLine("Thread 1 executed..." + obj);
        }

       public static void Function2(Object obj)
        {
            Console.WriteLine("Thread 2 executed..." + obj);
        }
    }
}
