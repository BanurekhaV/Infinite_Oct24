using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dotnet
{   
    class DelegatesAsParameter
    {
        delegate int Arithmetic(int x, int y);
        static void Main()
        {
            DoOperation(10, 2, Multiply);
            DoOperation(10, 2, Divide);
            Console.Read();
        }

        static void DoOperation(int x, int y, Arithmetic Adel)  //delegate type as a parameter
        {
            int z = Adel(x, y);
            Console.WriteLine(z);
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
