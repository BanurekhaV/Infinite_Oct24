using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    partial class gotoLabels
    {
       // public partial void pMethod(string s);
       
    }
    class TypesofClasses 
    {
        static void Main()
        {
            MyStatic.data = 6;
            MySealed ms = new MySealed();
            ms.Display();
            Shapes s; //cannot instantiate an abstract class
            s = new Square(6);
            Console.WriteLine(s.Area());
            Square sq = new Square(3);
            Console.WriteLine(sq.Area());
            Console.Read();
        }
    }

    static class MyStatic
    {
        public static int data;
    }

    sealed class MySealed
    {
        public void Display()
        {
            Console.WriteLine("Hi reached Display");
        }
    }
}
