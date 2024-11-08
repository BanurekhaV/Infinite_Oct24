using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dotnet
{
    public delegate T Trans<T>(T arg);  // generic delegate
    class GenericDelegates
    {
        public static void Transform<T>(T[] values,Trans<T> t)
        {
            for(int i=0; i<values.Length;i++)
            {
                values[i] = t(values[i]);
            }
        }
    }

    class Driver
    {
        static void Main()
        {
            // int[] values = new int[] { 4, 5, 6 };
            float[] values = new float[] { 4.4f, 5.5f, 6.6f };

            GenericDelegates.Transform(values, Square);

            foreach(var i in values)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

        static int Square(int x)
        {
            return x * x;
        }

        static float Square(float x)
        {
            return x * x;
        }
    }
}
