using System;
using System.IO;
using static System.Console;
using static System.Convert;


namespace Day10_Dotnet
{
    class DisposableEg : IDisposable
    {
        //constructor   
        public DisposableEg()
        {
            WriteLine("Enter a number :");
            int num = ToInt32(ReadLine());
            WriteLine("Allocating Resources.....");
        }

        public void DoSomething()
        {
           WriteLine("We are using the allocated resources and soing something....");
        }
        public void Dispose()
        {
            WriteLine("Releasing Resoucrces...");
        }

        ~DisposableEg()
        {
            WriteLine("Finalized called");
            Read();
        }
        static void Main()
        {
            WriteLine("Disposable Example 1..");

            //using block for allocating and deallocating resources
            using(var dispobj = new DisposableEg())
            {
                dispobj.DoSomething();               

            } //end of the using block, that calls the Dispose() automatically
            WriteLine("------------------");
            DisposableEg disp2 = new DisposableEg();
            disp2.DoSomething();
            disp2.Dispose();
            WriteLine("Example 2...");

            using (StreamReader sr = new StreamReader(@"C:\Banu\Infinite_1\Sample.txt"))
            {
                WriteLine(sr.ReadToEnd());
               // Console.WriteLine("The generation no of sr is : " + GC.GetGeneration(sr));
            }
          
           // Console.WriteLine("The bytes collected from sr is : " + GC.CollectionCount(0));
           Read();
        }
    }
}
