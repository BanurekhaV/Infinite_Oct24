using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Parent
    {
        int p;
        //empty constructor
        internal Parent()
        {
            Console.WriteLine("This is a message from parent");
        }

        //parameterized constructor
        public Parent(int x)
        {
            p = x;
            Console.WriteLine("Parents data is " + p);
        }
    }

    class Child : Parent
    {
        int c;

        public Child()
        {
            Console.WriteLine("This is msg from child");
        }

        public Child(int a)
        {
            c = a;
            Console.WriteLine("Childs Data " + c);
        }
    }
    class Base_Derived_Constructor_Call
    {
       static void Main()
        {

        }
    }
}
