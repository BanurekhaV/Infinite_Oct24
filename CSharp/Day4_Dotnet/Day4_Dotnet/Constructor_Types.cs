using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Customer Constructor 1..");
        }

        public Customer(int a):this()
        {
            Console.WriteLine("Customer Constructor 2..");
        }

        public Customer(string s, int x):this(100)
        {
            Console.WriteLine("Customer Constructor 3..");
        }

    }
    class Constructor_Types 
    {
        static void Main()
        {
          //  Customer c1 = new Customer("hello",5);

            Console.WriteLine("----------------");
            Labrador lb = new Labrador("Hero", 5, 12.5);
            Console.Read();
        }
    }

    //to understand constructor types
    class Dog
    {
        public string Name;
        public int Age;
       
      protected Dog()
        {
            Console.WriteLine("We are in the process of Dog Construction..");
        }
    }

    class Labrador : Dog
    {
        public double measurements;

        public Labrador(string name, int age, double m)
        {
            Console.WriteLine("Labrador under construction..");
            Name = name;
            Age = age;
            measurements = m;
        }


    }
}
