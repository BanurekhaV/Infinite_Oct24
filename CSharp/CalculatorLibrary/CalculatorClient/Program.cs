using System;
using CalculatorLibrary;

namespace CalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClass cc = new CalculatorClass();
            Console.WriteLine(cc.AddFunc(10, 5));
            Console.WriteLine(cc.SubtractFunc(10, 5));
            Console.Read();
        }
    }
}
