using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class Program
    {
        int[] array = new int[5];
        #region
        static void Main(string[] args)
        {
            //var a = Divide(10, 0);
            //Console.WriteLine(a);
            Program p = new Program();
            try
            {
                p.Show(p.array);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace.ToString());
                Console.WriteLine("The Name of the method where exception occured is " + nameof(p.Show));
            }
            Console.Read();
        }
        #endregion
        #region
        int Show(int[] a)
        {
            a[5] = 10;
            return a[5];
        }
        #endregion

        /// <summary>
        /// Divide helps in returning exceptions if it fails
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Divide(int x, int y)
        {
            try
            {
                //throws allows us to throw an exception directly from an expression
                return y != 0 ? x % y : throw new DivideByZeroException();
            }

            catch (DivideByZeroException) { Console.WriteLine("Error"); }
            return -1;
        }
    }
}
