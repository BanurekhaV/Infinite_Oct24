using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class ExceptionFilters
    {
        static void Main()
        {
            try
            {
                //int[] arr = new int[5];
                //arr[10] = 15;
                int x = 0;
                int res = 5 / x;
            }
            catch(Exception e)when (e.GetType().ToString() == "System.IndexOutOfRangeException")                             
            {
                Console.WriteLine(e.Message);
                 sometask();
            }
            catch (Exception e) when (e.GetType().ToString() == "System.DivideByZeroException")
            {
                Console.WriteLine("dont divide a number with 0");
            }
            //catch (DivideByZeroException e) when (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            //{
            //    Console.WriteLine("Today is Friday");
            //}
            Console.Read();
        }

        static void sometask()
        {
            Console.WriteLine("this is a task..");
        }
    }
}
