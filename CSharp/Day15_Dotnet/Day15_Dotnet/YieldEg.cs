using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class YieldEg
    {
        public static IEnumerable<string> GetList()
        {
            List<string> Countries = new List<string>() { "India", "Japan", "Korea", "China", "Singapore", "US" };
            
            foreach(var c in Countries)
            {
                 yield return c;
            }
        }

        public static IEnumerable<int>RandomYears()
        {
            int year;
            Random randyear = new Random();
            while(true)
            {
                year = randyear.Next(2000, 2024);
                if(year % 4 == 0)
                {
                    Console.WriteLine($"{year} is a Leap Year");
                    yield break;
                }
                yield return year;
            }
            Console.WriteLine("We are done with Random Years..");
        }
        static void Main()
        {
            IEnumerable<string> countrylist = GetList();

            foreach(var item in countrylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");
            foreach(int y in YieldEg.RandomYears())
            {
                Console.WriteLine(y);
            }
            Console.Read();
        }
    }
}
