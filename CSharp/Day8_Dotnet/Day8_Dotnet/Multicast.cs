using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dotnet
{
    public delegate void MultiDel();
    public delegate int MultiDelRet(int x);
    class Multicast
    {
        static void Main()
        {
            Multicast mc = new Multicast();

            //option 1 with many delegate objects cumulating into a single object
            MultiDel md, md1, md2, md3;
            md1 = new MultiDel(mc.Method1);
            md2 = new MultiDel(mc.Method2);
            md3 = new MultiDel(mc.Method3);

            md = md2 + md1 + md3;
            md();

            md -= md3;
            md();

            //option 2 - Multicasting with just one delegate object
            //MultiDel md = new MultiDel(mc.Method1);
            //md += mc.Method2;
            //md += mc.Method3;

            //md();
            ////remove one method from the delgate
            //Console.WriteLine("--------------");
            //md -= mc.Method2;
            //md();
            Console.WriteLine("---Multicast with return type------");
            MultiDelRet mdr = new MultiDelRet(MulticastWithReturn.Square);
            mdr += MulticastWithReturn.Triple;

            int result = mdr(5);
            Console.WriteLine(result);
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

    //example 2 for multicast with valid return types

    class MulticastWithReturn
    {
        static int p;

        public static int Square(int x)
        {
            p = x * x;
            return p;
        }

        public static int Triple(int y)
        {
            p += y * y * y;
            return p;
        }

    }

}
