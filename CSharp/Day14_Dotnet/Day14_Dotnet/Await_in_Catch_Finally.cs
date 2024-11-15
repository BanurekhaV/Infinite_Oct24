using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Day14_Dotnet
{
    class Await_in_Catch_Finally
    {
        static void Main()
        {
            // addAsync();

            FileRead fr = new FileRead();
            Console.WriteLine(" Object created successfully");
            fr.ReadOperation();
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

     class FileRead
     {
        StreamReader sr;
        public async void ReadOperation()
        {
            try
            {
                 sr = File.OpenText("MyFile.txt");
                Console.WriteLine($"The first Line of the File is : \\{sr.ReadLine()}");
                sr.Close();
            }
            catch {

                Show();

                for(int i=0; i<5; i++)
                {
                    Console.WriteLine(i);
                    if (i == 3)
                    {

                        continue;
                    }
                }
                await FileNotFound(); 
                Console.WriteLine("Encountered Exception");
            }
            finally { await ExitProgram(); Console.WriteLine("We are terminating the program.."); }
        }

        async Task FileNotFound()
        {
            Console.WriteLine("Given file not found. Check for the file name or path..");

        }
        async Task ExitProgram()
        {
                Console.WriteLine("\n Press any Key to exit");
            sr.Close();
        }

        async Task Show()
        {
            Console.WriteLine("This is Show ");
        }

     }

}
