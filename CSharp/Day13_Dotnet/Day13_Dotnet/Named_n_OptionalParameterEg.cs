using System;
using System.Collections.Generic;
using System.Linq;
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

        static void Main()
        {
            Console.WriteLine(AddNumber(10,20)); //supplying argument values positionally

            //named arguments can be supplied in either order
            Console.WriteLine(AddNumber(x:20,y:10)); // named arguments in the same order
            Console.WriteLine(AddNumber(y:5, x:8)); // named arguments in chnaged order

            //Positional arguments cannot follow named arguments
            Console.WriteLine(AddNumber(y:1,2));

            //Named arguments can follow positional
            Console.WriteLine(AddNumber(3,y:5));
            Console.Read();
        }
    }
}
