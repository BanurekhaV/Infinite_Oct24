using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    class EqualityEg
    {
        static void Main()
        {
            int a = 5, b = 6, c = 5;

            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(b.CompareTo(a));
            Console.WriteLine(c.CompareTo(a));

            Console.WriteLine("------- == operator ------- ");
            Console.WriteLine(a == c);
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(a.Equals(b));

            Console.WriteLine("===== for string reference types- ======");

            string str1 = "Hello";
            string str2 = "Hello";
            string str3 = "hello";

            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1 == str3);

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.Equals(str3));

            Console.WriteLine("------ with object references ------");

            object obj1 = new StringBuilder("Hello");
            object obj2 = "Hello";

            Console.WriteLine(obj1 == obj2);
            Console.WriteLine(obj1.Equals(obj2));

            Console.WriteLine("-------- refernce equals with string builder --------");

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            Console.WriteLine(object.ReferenceEquals(sb1,sb2));

            sb1 = sb2;
            Console.WriteLine(object.ReferenceEquals(sb1, sb2));

            Console.WriteLine("----- reference equals with strings -----");

            string s1 = "A";
            string s2 = "a";
            Console.WriteLine(object.ReferenceEquals(s1,s2));

            s1 = s2;
            Console.WriteLine(object.ReferenceEquals(s1,s2));
            Console.Read();
        }
    }
}
