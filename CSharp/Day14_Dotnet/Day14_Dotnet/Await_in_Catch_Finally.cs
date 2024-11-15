using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class Await_in_Catch_Finally
    {
        static void Main()
        {
            addAsync();
            Console.Read();
        }

        async static Task addAsync()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 15;
            }
            catch(Exception e)
            {
                //we shall use await
                await ExceptionOccurred();
                
            }
            finally
            {
                //use await
                await ReleasingOfResources();
            }

        }

        async static Task ExceptionOccurred()
        {
            Console.WriteLine("Index of an Array Exception occured");
            Thread.Sleep(10000);
        }

        async static Task ReleasingOfResources()
        {
            Console.WriteLine("All allocated resources are being released..");
            Thread.Sleep(5000);
        }
    }

}
