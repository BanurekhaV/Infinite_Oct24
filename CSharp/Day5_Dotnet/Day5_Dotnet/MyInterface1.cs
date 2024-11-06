using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    interface MyInterface1
    {
        void MyIntMethod_1();
    }

    interface MyInterface2
    {
       void MyIntMethod_1();
    }

    class IntImplementor : MyInterface1, MyInterface2
    {
        void MyInterface1.MyIntMethod_1() // explicit implementation, cannot use access modifiers
        {
            Console.WriteLine("This is MyInterface 1..");
        }

         public void MyIntMethod_1()  //default method
        {
            Console.WriteLine("This is MyInterface 2..");
        }

        static void Main()
        {
            IntImplementor ii = new IntImplementor();

            // ii. unable to access the interface member
            // option 1 to call the interface method by typecasting the class reference to the specific interface
            ii.MyIntMethod_1();  //default method being called with the class reference
            Console.WriteLine("---------------");
            ((MyInterface1)ii).MyIntMethod_1();
            ((MyInterface2)ii).MyIntMethod_1();

            //option 2

            MyInterface1 mf1 = new IntImplementor();
            mf1.MyIntMethod_1();
            MyInterface2 mf2 = new IntImplementor();
            mf2.MyIntMethod_1();

            Console.Read();
        }
    }
}
