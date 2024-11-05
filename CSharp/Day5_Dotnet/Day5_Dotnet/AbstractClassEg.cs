using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    abstract class Shapes
    {
        abstract public int Area(); //abstract method

        public void DrawShape()  // non abstract method
        {
            Console.WriteLine("Drawing a Shape..");
        }
    }

    class Square : Shapes
    {
        int side = 0;

        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }
    }
    //class AbstractClassEg
    //{

    //}
}
