using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Parent
    {
        public int p;
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
            Console.WriteLine("Empty Child..");
        }

         // instantiating the base type thru the derived type constructor
        
        public Child(int a):base(a)
        {
            c = a;
            Console.WriteLine("Parents Data " + base.p);
            Console.WriteLine("Childs Data " + c);
        }

        public Child(int a, int b):base(b)
        {
            c = a;
            Console.WriteLine("Parents Data " + base.p);
            Console.WriteLine("Childs Data " + c);
        }
    }
    class Base_Derived_Constructor_Call
    {
       static void Main()
        {
            Parent p1 = new Parent(); //calls directlty the empty constructor of the Parent
            Child c1 = new Child(); //calls the empty const. of the Parent and then Child
            Parent parent = new Parent(5); // calls the one parameter const. of the Parent
            Child child = new Child(10); // calls one parameter const. of the Parent and then one parameter const. of the child 

            Child child2 = new Child(25, 55); // calls the one parameter const. of the Parent and then the 2 parameter const. of the Child
            Console.Read();
        }
    }
}
