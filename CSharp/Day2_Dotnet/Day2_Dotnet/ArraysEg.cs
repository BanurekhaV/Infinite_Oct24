using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class ArraysEg
    {
        public static void SingleDimension()
        {
            int[] data = new int[] { 42, 6, 8, 35, 3 };
            Console.WriteLine(data.Length + " " + data.Rank);
            Console.WriteLine("----------Before Sort---------");
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------After Sort----------");
            Array.Sort(data);
            //Array.Reverse(data);
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }
        }

        //single 
        
    }

    class TestArrays
    {
        public static void Main()
        {
            ArraysEg.SingleDimension();
            Console.Read();
        }
    }
}
