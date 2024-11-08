using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dotnet
{
    public delegate void MultiDel();
    class Multicast
    {
        static void Main()
        {
            Multicast mc = new Multicast();

            MultiDel md = new MultiDel(mc.Method1);
            md += mc.Method2;
            md += mc.Method3;

            md();
            //remove one method from the delgate
            Console.WriteLine("--------------");
            md -= mc.Method2;
            md();
            Console.Read();
        }

        public void Method1()
        {
            Console.WriteLine("Method 1...");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2...");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3...");
        }
    }
}
