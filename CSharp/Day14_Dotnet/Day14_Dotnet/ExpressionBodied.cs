using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class ExpressionBodied
    {
        public static int year = 2016;
        static void Main()
        {
            Console.WriteLine(LeapYear());
            Console.WriteLine(squareroot(5));
            Console.WriteLine(CalcOps(10,2));
            Console.Read();
        }

        //usual way of writing code
        //public static string LeapYear()
        //{
        //    return "Is " + year + " a leap year ? " + DateTime.IsLeapYear(year);
        //}

        //with expression bodied member
       // public static string LeapYear() => "\n Is \\{year} a leap year ? " + DateTime.IsLeapYear(year);

        //or
        public static string LeapYear() => $"Is {year} a leap year ? " + DateTime.IsLeapYear(year);

        public static int squareroot(int side) => side * side;
        public static  int CalcOps(int a, int b) => ((a + b) + (a - b) + (a * b) + (a / b));
    }
}
