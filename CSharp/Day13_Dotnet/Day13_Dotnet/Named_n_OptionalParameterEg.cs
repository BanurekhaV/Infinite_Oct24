using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    class Named_n_OptionalParameterEg
    {
        static int AddNumber(int x, int y)
        {
            return x + y;
        }

        //optional parameter with default value
        static int Addnos(int fnum, int snum = 7, int tnum = 5)
        {
            return fnum + snum + tnum;
        }

        //optional parameters have to be to the right hand side of the argument list
        //static int MulNo(int a = 8, int b)
        //{
        //    return a * b;
        //}

        //Optional parameter with optional attribute
        static int Add(int fnum, [Optional]int snum)
        {
            return fnum + snum ;
        }

        static void Main()
        {
            Console.WriteLine(AddNumber(10,20)); //supplying argument values positionally

            //named arguments can be supplied in either order
            Console.WriteLine(AddNumber(x:20,y:10)); // named arguments in the same order
            Console.WriteLine(AddNumber(y:5, x:8)); // named arguments in chnaged order

            //Positional arguments cannot follow named arguments
          //  Console.WriteLine(AddNumber(y:1,2));

            //Named arguments can follow positional
            Console.WriteLine(AddNumber(3,y:5));

            Console.WriteLine("------------Optional Argument with Default------");
            Console.WriteLine(Addnos(2,4,6));
            Console.WriteLine(Addnos(2,4));
            Console.WriteLine(Addnos(5));

            Console.WriteLine("------------Optional Argument with Optional Attribute------");

            Console.WriteLine(Add(20));
            Console.WriteLine(Add(20,5));
            Console.Read();
        }
    }
}
