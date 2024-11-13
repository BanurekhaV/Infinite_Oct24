using System;

using System.Threading;

namespace Day12_Dotnet
{
    class ThreadStartEg
    {
        static void Main()
        {
            //creating the threadstart object instance by passing a method name
            ThreadStart tsobj = new ThreadStart(DisplayNumbers);

            //passing the threadstart object to the thread object
            Thread t = new Thread(tsobj); //or as below
           // t = new Thread(DisplayNumbers);

            t.Start();
            Console.Read();
        }

        static void DisplayNumbers()
        {
            for(int i=0; i<=5;i++)
            {
                Console.WriteLine("The number : " + i);
            }
        }
       
    }

    /*The above instantiation of the Thread Class thru the ThreadStart delegate 
    /can be achieved as below
    1. Thread t1 = new Thread(new ThreadStart(DisplayNumbers));
    2. Thread t1 = new Thread(delegate(){DisplayNumbers();});
    3. Thread t1 = new Thread(() => {DisplayNumbers();});
    4. Thread t1 = new Thread(() => DisplayNumbers());

    //using Anonymous Method
    Thread t1 = new Thread(()=>{
       for(int i=0; i<=5; i++)
       {
         Console.WriteLine("The Number : " + i);
       }
    });

    */
}
