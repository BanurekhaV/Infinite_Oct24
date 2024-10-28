using System;


namespace Day1_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to C# ");
            Console.Write("Enter Your Name : ");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter your Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Welcome "  + uname + "aged" + "To Csharp programming");  // concatenation 
            //Console.WriteLine("Welcome {0} {1} to CSharp Programming", uname, age); //place holder
            Console.WriteLine($"Welcome {uname} aged {age} to CSharp programming"); // string interpolation
            Console.Read();
        }
    }
}
