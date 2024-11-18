using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class Tuples
    {
        static void Main()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            //option 1
            //  Tuple<int, double> t = Calculate(values);
            //  Console.WriteLine($"Thre are {t.Item1} elements and their Sum is {t.Item2}");

            //option 2 give a better readabilty
            //var result = Calculate(values);
            //Console.WriteLine($"Thre are {result.Item1} elements and their Sum is {result.Item2}");

            //option 3 named parameters
           // var result = Calculate(values);
            //Console.WriteLine($" There are {result.count} elements and their sum is {result.sum}");

            //option 4 explicit names to store results - tuple deconstruction
            var (countResult, SumResult) = Calculate(values);
            Console.WriteLine($"There are {countResult} elements and their sum is  {SumResult}");

            Console.WriteLine("_____________________");
            (double least, double highest, double average) = GetResults(values);
            Console.WriteLine($" Lowest : {least}, Highest : {highest} and Average : {average}");
            Console.Read();
        }

        //decl the return type as tuple option 1
       // static Tuple<int, double> Calculate(IEnumerable<double> values)
       
        //option 2:
       // static (int,double)Calculate(IEnumerable<double>values)

        //option 3 tuple deconstruction by using the type and parameter name of the return value
        static (int count, double sum)Calculate(IEnumerable<double>values)
        {
            int count = 0;
            double total = 0.0;
            foreach(var v in values)
            {
                count++;
                total += v;
            }

            //option 1
            //creating an object of the tuple class by calling the create static method
            // and returning that object

            //Tuple<int, double> ret_t = Tuple.Create(count, total);
            //return ret_t;

            //option 2, 4 and 4
            return (count, total);
        }

        static (double,double,double)GetResults(List<double> numbers)
        {
            return (numbers.Min(), numbers.Max(), numbers.Average());
        }
    }
}
