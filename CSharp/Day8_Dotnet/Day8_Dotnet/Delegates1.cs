using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dotnet
{
    delegate void EmpHandler(string str);  //decl. of delegate
    public delegate int NumberChanger(int n);
    class Employee
    {
        public static void Message(string s)
        {
            Console.WriteLine(s);
        }

        public void DisplayUser(string uname)
        {
            Console.WriteLine( "Hello and Welcome : " + uname);
        }

        public void Show()
        {
            Console.WriteLine("welcome to Delegates of C#");
        }
    }

    class Numbers
    {
        static int num = 0;

        public static int AddNum(int a)
        {
            num += a;
            return num;
        }

        public static int MultiNum(int b)
        {
            num *= b;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }
    class Delegates1
    {
        public static void Main()
        {
            Employee e = new Employee(); //class object

            EmpHandler eh1 = new EmpHandler(Employee.Message); //delegate pointing to a static method of a class
            EmpHandler eh2 = new EmpHandler(e.DisplayUser);

            //to call the function thru delegate
            eh1.Invoke("Infinite Ltd.");
            eh1("Infinite Computers Ltd.,");
                        
            eh2("Manisha");

            Console.WriteLine("-----Delegate Example 2-------");

            NumberChanger nc1 = new NumberChanger(Numbers.AddNum);
            NumberChanger nc2 = new NumberChanger(Numbers.MultiNum);

            Console.WriteLine("Value of Num : {0}", Numbers.getNum());

            //inoking the delegate
            nc1(25);

            Console.WriteLine("Value of Num : {0}", Numbers.getNum());

            nc2(5);
            Console.WriteLine("Value of Num : {0}", Numbers.getNum());
            Console.Read();
        }
        

    }
}
