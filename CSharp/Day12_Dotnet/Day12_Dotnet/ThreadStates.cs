using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day12_Dotnet
{
    class ThreadStates
    {
        static void Main()
        {
            try
            {
                //unstarted state
                Thread t = new Thread(SomeFunction);
                Console.WriteLine($"before Start  , IsAlive : {t.IsAlive}, Thread State : {t.ThreadState}");

                //runnable state
                t.Start();
                Console.WriteLine($"before Start  , IsAlive : {t.IsAlive}, Thread State : {t.ThreadState}");

                //not runnable
                t.Suspend();
                Console.WriteLine($"before Start  , IsAlive : {t.IsAlive}, Thread State : {t.ThreadState}");

                //resume
                t.Resume();
                Console.WriteLine($"before Start  , IsAlive : {t.IsAlive}, Thread State : {t.ThreadState}");

                //abort
                t.Abort();
                Console.WriteLine($"before Start  , IsAlive : {t.IsAlive}, Thread State : {t.ThreadState}");

                t.Start();
                Console.WriteLine($"before Start  , IsAlive : {t.IsAlive}, Thread State : {t.ThreadState}");
                Console.Read();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
               // Console.Read();
            }
            Console.Read();
            
        }

        public static void SomeFunction()
        {
            for(int i = 0; i < 3;i++ )
            {
                Thread.Sleep(2000);              
            }
            Console.WriteLine("Some Function Completed...");
        }
    }
}
