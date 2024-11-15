using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class NonNullableReference
    {
        static void Main()
        {
           // int nonull = null;
            int ? yesnull = null;
            int zeroifnull = yesnull ?? 0;

            Nullable<int> number = null;

            string text = null;

            PassNull(text);
            Console.Read();
        }

        public static void PassNull(string text)
        {
            Console.WriteLine("The First Character is  : "+ text[0]);
        }
    }
}
