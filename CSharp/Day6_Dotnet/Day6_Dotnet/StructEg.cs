using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    interface IShape
    {
        double GetArea();        
    }
    struct Rectangle : IShape
    {
        //data items 
        public double length, breadth;

        public Rectangle(double l)
        {
            length =l;
            breadth = 2.0;
        }

        public Rectangle(double ln, double bd)
        {
            length = ln;
            breadth = bd;
        }
        public double GetArea()
        {
            return length * breadth;
        }
    }

    
    class StructEg
    {
        static void Main()
        {
            Rectangle r = new Rectangle();
            Rectangle r1 = new Rectangle(2.0);
            double area = r1.GetArea();
            Console.WriteLine(area);
            Console.Read();
            
        }
    }
}
