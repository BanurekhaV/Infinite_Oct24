using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class ImplicitlyTyped
    {
        public void Implicit_types()
        {
            int x;  //just declaration
            x = 10; // assignment

            float f = 345.678f;

            var v1 = 4567.567; // declare and assign at the same time


            dynamic d;  //reference type
            d = 5;
            d = 'u';
            d = "hello";
            d = true;

            var myanonymoustype = new {data1="CSharp",
                                       data2= 5,
                                       data3 = true};

            Console.WriteLine(myanonymoustype.data1 + " "+ myanonymoustype.data2);
        }
    }
}
