using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    class ExceptionsEg1
    {
        static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 nos :");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;

                int[] arr = { 1, 2, 3, 4 };
                Console.WriteLine(arr[6]);
                Console.WriteLine("C is " + c);
            }
            
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Source + " "+ fe.Message);
                Console.WriteLine("Please enter only numbers");
            }

            catch(DivideByZeroException de)
            {
                Console.WriteLine(de.StackTrace + " " + de.Message);
                Console.WriteLine("Cannot divide a number by 0");
            }
            //catch(IndexOutOfRangeException ie)
            //{
            //    Console.WriteLine("Cannot read beyond the Limit");
            //}

            catch (Exception e)
            {
                Console.WriteLine("Something went wrong try later..");
            }

            finally
            {
                Console.WriteLine("Reached Finally..");
            }
                       
            Console.Read();
        }
    }
}
