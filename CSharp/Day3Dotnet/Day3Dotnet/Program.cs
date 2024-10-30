using System;
using System.Text;

namespace Day3Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOps();
            Console.Read();
        }

        public static void StringOps()
        {
            string s = "Hello";
            Console.WriteLine("S for the first time is :{0}", s.GetHashCode());

            //strings are immutable
            s = "Hello World";
            Console.WriteLine("S for the second time is :{0}", s.GetHashCode());

            string s1 = "CSharp";
            Console.WriteLine("S1 is at :{0}", s1.GetHashCode());
            Console.WriteLine(s1);
            string s2 = s1;  // reference of s1 is assigned to s2 also

            Console.WriteLine("S2 is at :{0}", s2.GetHashCode());
            Console.WriteLine(s2);

            string s3 = "Hello";

            Console.WriteLine("S3 is at :{0}", s3.GetHashCode());
            Console.WriteLine(s3);

            //checking by instantiating a string object
            char[] carr = new char[] { 'H','e','l','l','o' };
            string s4 = new string(carr);

            Console.WriteLine("S4's hash code is {0}", s4.GetHashCode());

            Console.WriteLine("--------String Builder-------");

            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("Sb's hash code is {0}" , sb.GetHashCode());

            sb.Append(" World of CSharp from Microsoft ");
            Console.WriteLine("Sb's hash code is {0}", sb.GetHashCode());
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);

        }
    }
}
