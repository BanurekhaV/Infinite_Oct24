using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    class LocalFunctions
    {
        public static void Main()
        {
            int a = 10, b = 5, c = 100;

            int sum = Sum(a, b);
            int diff = Difference(a, b);
            Console.WriteLine($"The Sum of {a} and {b} is {sum}");
            Console.WriteLine($"The Difference of {a} and {b} is {diff}");

            Console.WriteLine("Added Sum " + Sum(sum, b));
            //local function
            int Sum(int x, int y)
            {
                return c + x + y;
            }

            int Difference(int x, int y)
            {
                return x - y;
            }
            
            Console.Read();
        }
        
        
    }
}
