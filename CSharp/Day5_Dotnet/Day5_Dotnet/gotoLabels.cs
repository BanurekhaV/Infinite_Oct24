using System;

namespace Day5_Dotnet
{
    partial class gotoLabels
    {
        //public partial void pMethod(string s)
        //{
        //    Console.WriteLine("hi partial" + s);
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Goto labels");

            goto infinite;
            Console.WriteLine("Printing Statement 2");
            Console.WriteLine("Printing Statement 3");

        infinite:
            Console.WriteLine("Infinite Ltd., welcomes all the new Assosciates..");

            goto myLabel;

            Console.WriteLine("You have reached My Label..");
            Console.WriteLine("See you soon..");

        myLabel:
            Console.WriteLine("Bye from me..");

        doagain:
            Console.WriteLine("Enter a Number Less than 10");
            int num = int.Parse(Console.ReadLine());
            if(num >= 10)
            {
                Console.WriteLine("Number should be less than 10");
                goto doagain;
            }
            Console.WriteLine(num + " is less than 10");
            Console.Read();
        }
    }
}
