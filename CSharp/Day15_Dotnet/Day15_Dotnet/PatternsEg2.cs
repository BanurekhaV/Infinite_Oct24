using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class Shape
    {
        public const float PI = 3.14f;
    }

     class Circle : Shape
     {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
     }

    class Rectangle : Shape
    {
        public double Length { get; }
        public double Breadth { get; }

        public Rectangle(double l, double b)
        {
            Length = l; Breadth = b;
        }
    }

    class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
        }
    }

    class PatternsEg2
    {
        //Before C# 7.0
        static void Main()
        {
            Circle c = new Circle(10);
            DisplayArea(c);
            Rectangle r = new Rectangle(6, 5);
            DisplayArea(r);
            //to appreciate switch with when
            Rectangle r1 = new Rectangle(5, 5);
            DisplayArea(r1);
            Triangle t = new Triangle(10, 5);
            DisplayArea(t);
            Console.Read();
        }

       //public static void DisplayArea(Shape shape)
       // {
       //     //before C# 7.0 using is operator
       //     //testing each type in a series and then casting it accordingly
       //     if(shape is Circle)
       //     {
       //         Circle circle = (Circle)shape;
       //         Console.WriteLine("Area of Circle is : " + circle.Radius * circle.Radius * Shape.PI );
       //     }
       //     else if(shape is Rectangle)
       //     {
       //         Rectangle rect = (Rectangle)shape;
       //         Console.WriteLine("Area of Rectangle is : " + rect.Length * rect.Breadth);
       //     }
       //     else if(shape is Triangle)
       //     {
       //         Triangle tri = (Triangle)shape;
       //         Console.WriteLine("Area of Triangle is  : " + 0.5 * tri.Base * tri.Height);
       //     }
       //     else
       //     {
       //         throw new ArgumentException(message: "Invalid Shape ", paramName: nameof(shape));
       //     }
       // }

        //with switch after patterns of c# 7.0
        public static void DisplayArea(Shape shape)
        {
            switch(shape)
            {
                case Rectangle r when r.Length == r.Breadth:
                    Console.WriteLine("Area of Square : " + r.Length * r.Breadth);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle : " + r.Length * r.Breadth);
                    break;                             
                case Circle c:
                    Console.WriteLine("Area of Circle : " + c.Radius * c.Radius *Shape.PI);
                    break;
                case Triangle t:
                    Console.WriteLine("Area of Triangle : " + 0.5*t.Base*t.Height);
                    break;
                default:
                    throw new ArgumentException(paramName: nameof(shape), message: "Invalid Shape");

            }
        }
    }
}
