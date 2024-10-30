using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Dotnet
{
    public class AccessSpecifiersEg
    {
        int privatemember;

        public int publicmember = 100;

        internal int internalmember = 1000;

        protected int protectedmember = 10000;

         internal protected int pimember = 15;
        public void acceptdata()
        {
            Console.WriteLine("Enter value for private member");
            privatemember = Convert.ToInt32(Console.ReadLine());
        }

        public void showdata()
        {
            Console.WriteLine(privatemember + " " + publicmember + " " + 
                internalmember + " " + protectedmember + " "+ pimember);
        }
    }
}
