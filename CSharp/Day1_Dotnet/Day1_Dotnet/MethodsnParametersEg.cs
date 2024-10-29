using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Dotnet
{
    class MethodsnParametersEg
    {
        public static void SimpleMethod(int num)   //by value signature
        {
            num = 100;
            Console.WriteLine("value of num " + num);
        }

        public static void SimpleMethod2(ref int num) // by ref signature
        { 
            num = 100;
            Console.WriteLine("value of num " + num);
        }

        //out parameter example, when we need multiple return data from a function
        public static int Calculator(int a, int b, out int sum, out int product, out int div)
        {
            sum = a + b;  //addition
            product = a * b;  //multiplication
            div = a / b;  //division
            return a - b; // difference
        }

        //params example 1
        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} number of elements" , numbers.Length);
        }

        //params example 2

        public int AddElements(params int[] arr)  // non static or instance function
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }

    class Driver
    {
        public static void Main()
        {
            int i = 10;
            MethodsnParametersEg.SimpleMethod(i);  //by value
            Console.WriteLine("value of i " + i);
            MethodsnParametersEg.SimpleMethod2(ref i); // by reference
            Console.WriteLine("value of i " + i);
            Console.WriteLine("-------Output Parameters--------");

            int Total, Prod, Difference, Div;

            Difference = MethodsnParametersEg.Calculator(12, 6, out Total, out Prod, out Div);
            Console.WriteLine("Sum = {0} Product = {1}, and Difference = {2}, Division = {3}", Total, Prod, Difference, Div);

            Console.WriteLine("---------Params Example-----------");
            int[] num = new int[] { 10, 20, 30 };  //or num[0]=10; num[1]=20;num[2]=30
            MethodsnParametersEg.ParamsMethod(); // 0 argument
            MethodsnParametersEg.ParamsMethod(25); // 1 argument
            MethodsnParametersEg.ParamsMethod(num);  // arraylist
            MethodsnParametersEg.ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8); // comma seperated list

            Console.WriteLine("=====================");
            MethodsnParametersEg mpeg = new MethodsnParametersEg();
            int Sum = mpeg.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine(Sum);
            Console.Read();
        }
    }
}
