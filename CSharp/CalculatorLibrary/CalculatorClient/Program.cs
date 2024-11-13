using System;
using System.Collections;
using System.Collections.Generic;
using CalculatorLibrary;
using CalculatorLibraryExtension;

namespace CalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClass cc = new CalculatorClass();
            Console.WriteLine(cc.AddFunc(10, 5));
            Console.WriteLine(cc.SubtractFunc(10, 5));
            Console.WriteLine("-------Accessing Extended methods-----");
            Console.WriteLine(cc.MultiplyFunc(10,5));
            Console.WriteLine(cc.DivideFunc(10,5));
            Console.WriteLine(cc.DivideFunc(10.5f,5.5f));
            Console.Read();
        }
    }
}
