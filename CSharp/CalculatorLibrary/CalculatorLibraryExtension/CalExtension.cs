using System;
using CalculatorLibrary;  //reference of the original namespace

namespace CalculatorLibraryExtension
{
    public static class CalExtension
    {
        public static int MultiplyFunc(this CalculatorClass cobj,int x, int y)
        {
            return x * y;
        }
    }

    public static class CalExtension2 
    {
        public static int DivideFunc(this CalculatorClass cobj,int x, int y)
        {
            return x / y;
        }

        public static float DivideFunc(this CalculatorClass cobj,float x, float y)
        {
            return x / y;
        }
    }
}
