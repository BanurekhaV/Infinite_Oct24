using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregates_General();
            Seed_Aggregates();
            Console.WriteLine("-----------------");
            Element_At();
            Console.WriteLine("----------");
            First_Operators();
            Console.WriteLine("-------------");
            Single_Eg();
            Console.WriteLine("----------------");
            Sorting_Func();
            Console.WriteLine("----------------");
            MultipleSort();
            Console.WriteLine("------------");
            GroupBy_Func();
            InnerJoins();
            Console.Read();
        }

        //aggregates general
        public static void Aggregates_General()
        {
            int[] numbers = { 2, 34, 5, 6, 7, 8, 9 };
            var sum = numbers.Max();
            Console.WriteLine(sum);
        }

        //aggregatation 
        public static void Seed_Aggregates()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum is {0}", numbers.Sum()); //15
            var res = numbers.Aggregate(10, (a, b) => a + b); //25
            Console.WriteLine("Aggregate Sum with seed :{0}", res);

            res = numbers.Aggregate((a, b) => a * b); //120

            Console.WriteLine("Just Aggregate is {0}", res);
        }

        static void Element_At()
        {
            string[] fruits = { "Apple", "Oranges", "Kiwi", "Banana", "Grapes" };

            var result = fruits.ElementAt(3); //banana
            Console.WriteLine(result);
            // result = fruits.ElementAt(5); //throws an exception

            //to avoid exceptions
            result = fruits.ElementAtOrDefault(5); // does not throw exceptions, instead returns null
            Console.WriteLine(result);
        }

        static void First_Operators()
        {
            string[] colors = { "red", "blue", "green", "yellow", "white" };
            Console.WriteLine(colors.First());
            Console.WriteLine(colors.Last());

            string[] colors1 = { };
            Console.WriteLine(colors1.FirstOrDefault());
            Console.WriteLine(colors1.LastOrDefault());
        }

        static void Single_Eg()
        {
            string[] names1 = { "Infinite Limited" };
            string[] names2 = { "Barack Obama", "Joe Biden", "Donald Trump" };
            string[] empty = { };

            Console.WriteLine(names1.Single());
            //Console.WriteLine(names2.Single()); // throws exception
            //Console.WriteLine(names2.SingleOrDefault()); // throws exception
            //Console.WriteLine(empty.Single()); // throws exception
            Console.WriteLine(empty.SingleOrDefault()); //does not throw exception
        }

        public static void Sorting_Func()
        {
            string[] names2 = { "Obama", "Joe Biden", "Donald Trump" };

            //sort in asc

            var namesort = names2.OrderBy(n => n);
            foreach(var n in namesort)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-----Descending sort------");

             namesort = names2.OrderByDescending(n => n);
            foreach (var n in namesort)
            {
                Console.WriteLine(n);
            }
        }

        //multiple sorting

        static void MultipleSort()
        {
            string[] capitals = { "Delhi", "Mumbai", "Ambal", "abcde", "Nagpur", "Bangalore", "Chennai", "Hyderabad","Ahmedabad" };

            var mulsort = capitals.OrderBy(c => c.Length).ThenBy(c => c);
            Console.WriteLine("-------Multi Sort Regular--------");

            foreach(string s in mulsort)
            {
                Console.WriteLine(s);
            }
           
            mulsort = capitals.OrderByDescending(c => c.Length).ThenByDescending(c => c);
            Console.WriteLine("-------Mutli sort descending------");

            foreach (string s in mulsort)
            {
                Console.WriteLine(s);
            }
        }

        //group by
        static void GroupBy_Func()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35, 42 };

            var result = numbers.GroupBy(num => (num % 10 == 0)); // query construction

            foreach(IGrouping<bool,int> gp in result)  //query execution
            {
                if(gp.Key==true)
                {
                    Console.WriteLine("Group 1 - Numbers Divisible by 10..");
                }
                else
                {
                    Console.WriteLine("Group 2 - Numbers not Divisible by 10...");
                }
                foreach(int n in gp)
                {
                    Console.WriteLine(n);
                }
            }
        }

        static void InnerJoins()
        {
            string[] str1 = { "India", "Japan", "US", "Korea", "Russia" };
            string[] str2 = { "China", "Pakistan", "Japan", "UK", "India", "Korea" };

            var result = str1.Join(str2, s1 => s1, s2 => s2, (s1, s2) => s2);

            Console.WriteLine("Post joining 2 strings");

            foreach(var country in result)
            {
                Console.WriteLine(country);
            }
        }
    }
}
