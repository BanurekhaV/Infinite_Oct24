using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    class Person
    {
        public int Age;
        public PersonDescription pdesc;

        public Person(int age, string f, string l)
        {
            Age = age;
            pdesc = new PersonDescription(f, l);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone(); // here references are copied
        }

        public Person DeepCopy()
        {
            Person Dcopy = new Person(this.Age, pdesc.FirstName, pdesc.LastName); //here values are copied
            return Dcopy;
        }
    }

    class PersonDescription
    {
        public string FirstName;
        public string LastName;

        public PersonDescription(string fn, string ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }
    }
    class ShallowVsDeepCopy
    {
        static void Main()
        {
            Person p1 = new Person(21, "Tarun", "Kumar");
            Person P2 = (Person)p1.ShallowCopy();
            Console.WriteLine("P1 Details "+ p1.Age + " " + p1.pdesc.FirstName);
            Console.WriteLine("P2 Details " + P2.Age + " " + P2.pdesc.FirstName);
            P2.pdesc.FirstName = "Kishore";
            Console.WriteLine("P1 Details " + p1.Age + " " + p1.pdesc.FirstName);
            Console.WriteLine("P2 Details " + P2.Age + " " + P2.pdesc.FirstName);
            Console.WriteLine("--------Hash Codes of P1 and P2-----");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(P2.GetHashCode());

            //Deep copy call
            Console.WriteLine("____________________________");
            Person p3 = p1.DeepCopy();
            Console.WriteLine(p1.pdesc.FirstName);
            Console.WriteLine(p3.pdesc.FirstName);

            p3.pdesc.FirstName = "Pradeep";
            Console.WriteLine(p1.pdesc.FirstName);
            Console.WriteLine(p3.pdesc.FirstName);

            Console.WriteLine("--------Hash Codes of P1 and P3-----");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p3.GetHashCode());

            Console.WriteLine("---Equating 2 objects----");
            P2 = p1;
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(P2.GetHashCode());
            Console.Read();
        }
    }
}
