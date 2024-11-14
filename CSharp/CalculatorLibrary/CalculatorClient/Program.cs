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

            Console.WriteLine("----Extension methods within the same namespace-----");
            ExtensionExample2 ee = new ExtensionExample2();
            ee.Function1();
            ee.Function2();

            Console.WriteLine(ee.Function3("Infinite Ltd.,")); 
            Console.Read();
        }
    }

    
}
