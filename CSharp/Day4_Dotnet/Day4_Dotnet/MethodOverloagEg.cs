using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class MethodOverloagEg
    {
        public static void swap(int num1, int num2)
        {
            num1 = num1 + num2; //num1 =5, num2=6 , num1=11, num2=5, num1=6
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("Swapping of Numbers num 1 = " + num1 + " num2 = " + num2);
        }

        public static void swap(char c1, char c2)
        {
            char temp = ' ';
            temp = c1;
            c1 = c2;
            c2 = temp;

            Console.WriteLine("Swapping of Characters c1 = "+ c1 + " c2= "+ c2);
        }

        static void Main()
        {
            swap(2, 4);  //line no. 13
            swap('z', 'a'); //line no.22
            Console.Read();
        }
    }

    class TestClass
    {
        public static void swap(char ch1, char ch2)
        {

        }
    }
}
