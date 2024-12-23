﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Shape
    {
        protected float R, L, B;

        //marking a function as Virtual allows the derived types to redefine the same function
        
        public virtual float Area()
        {
            return 3.14f * R * R;
        }

        public float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
         // new float L; name hiding using new keyword
        public void GetLB()
        {
            Console.WriteLine("Enter Length :");
            L = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth :");
            B = Convert.ToSingle(Console.ReadLine());
        }

        //we need to override the function Area() to suit the rectangle type
        //while overiding, we cannot alter the modifiers/access specifiers,
        //      parameters return type (signature)that is mentioned in the base class
        public override float Area()
        {
            GetLB();
            return L * B;
        }

        public new float Circumference() // method hiding using new keyword
        {
            return 2 * (L + B);
        }
    }

    class Circle : Shape
    {
        public override float Area()
        {
            GetRadius();
            return base.Area();
        }
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius :");
            R = float.Parse(Console.ReadLine());
        }
    }
    class OverrideExample
    {
        static void Main()
        {
            Shape shape = new Shape();
            Console.WriteLine("Shapes Area {0}", shape.Area()); // goto line no.15

            //Rectangle rectangle = new Rectangle();
            //rectangle.GetLB();
            //Console.WriteLine("Rectangles Area {0}", rectangle.Area());
            //Console.WriteLine("Rectangles Perimeter {0}", rectangle.Circumference()); 
            //Circle circle = new Circle();
            //circle.GetRadius();
            //Console.WriteLine("Circles Area {0}" , circle.Area()); // goto line no.15

            //actual dynamic polymorphism can be achieved using co-variance
            shape = new Rectangle();  // Co variance
           
            Console.WriteLine("Rectangles Area {0}", shape.Area());

            shape = new Circle();
            Console.WriteLine("Circles Area {0} ", shape.Area());
            
            Console.Read();
        }
    }
}
