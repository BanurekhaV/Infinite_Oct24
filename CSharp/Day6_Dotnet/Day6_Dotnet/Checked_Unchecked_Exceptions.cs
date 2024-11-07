using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    class Checked_Unchecked_Exceptions
    {
        static int maxint = 2147483647;
            
        //checked expressions
        public static int CheckOverFlow()
        {
            int a = 0;
            try
            {
                //checked expression that raises an exception
                a = checked(maxint + 10);
            }
            catch(System.OverflowException ofe)
            {
                Console.WriteLine("Checked : " + " " + ofe.ToString());
            }

            return a;
        }

        public static int UnCheckOverFlow()
        {
            int a = 0;
            try
            {
                //unchecked expression which will not raise any exception

                a = maxint + 10;
            }
            catch (System.OverflowException ofe)
            {
                Console.WriteLine("Checked : " + " " + ofe.ToString());
            }

            return a;
        }
    }
}
