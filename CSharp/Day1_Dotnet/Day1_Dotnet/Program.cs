using System;


namespace Day1_Dotnet
{
    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static void welcome(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to C# ");
            /* Console.Write("Enter Your Name : ");
             string uname = Console.ReadLine();
             Console.WriteLine("Enter your Age :");
             int age = Convert.ToInt32(Console.ReadLine());
             // Console.WriteLine("Welcome "  + uname + "aged" + "To Csharp programming");  // concatenation 
             //Console.WriteLine("Welcome {0} {1} to CSharp Programming", uname, age); //place holder
             Console.WriteLine($"Welcome {uname} aged {age} to CSharp programming"); // string interpolation

             Console.WriteLine("------------------");
             int i = 100;

             float f = i;  //implicit conversion
             Console.WriteLine(f);
             f = 12345234568789.56f;
             i = (int)f;   //typecasting
             Console.WriteLine(i + " with typecast");
             Console.WriteLine("Minimum Integer Value = {0}", int.MinValue);
             Console.WriteLine("Maximum Integer Value = {0}", int.MaxValue);
             i = Convert.ToInt32("9007"); //conversion function
             Console.WriteLine(i + " with conversion function"); */

            Console.WriteLine("----------Parse and Try Parse Example----------");

            string str = "245abc";
            //  int result = int.Parse(str); parse throws error when unable to parse
            int result = 0;
            bool answer = int.TryParse(str, out result);
            Console.WriteLine(result + " answer is " + answer);

            Console.WriteLine("--------Boxing and UnBoxing--------");

            int n = 10;
            object obj;
            obj = n;  //boxing
            Console.WriteLine(obj);
            string s = "AAAA";
            obj = s;  //implicit 

            float salary;
            Console.WriteLine("Enter salary , boolean and date of joining:");
            salary = float.Parse(Console.ReadLine());  //unboxing
            
            bool b;
            b = Convert.ToBoolean(Console.ReadLine());
           
            DateTime doj;
            doj = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"Salary is {salary}, Boolean Value is {b} and Dateof Joining is {doj} ");
            Console.Read();
        }
    } 
}
