using System;


namespace CalculatorClient
{
    
    static class ExtensionMethodsEg2
    {
        public static string Function3(this ExtensionExample2 ee, string s)
        {
            return s + " This is from extended method";
        }
    }
}
