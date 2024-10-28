using System;

namespace Day1_Dotnet
{
    class MethodsnParameters
    {
        public static void testfunc()
        {
            Console.WriteLine("static function of Methods class");
        }
    }

    class Instance_Static
    {
        public static void Evennos(int num) //static function
        {
            if (num % 2 == 0) Console.WriteLine("Even number");
        }

        public int multiply(int x, int y)  // instance function
        {
            Console.WriteLine("hi");
            return x * y;           
        }
        static void Main()  //static functions
        {
            Instance_Static instanceobj = new Instance_Static();
            Instance_Static instanceobj2 = new Instance_Static();
            Instance_Static.Evennos(5);
            Evennos(6);  //calling static function of the same class
            MethodsnParameters.testfunc(); //calling static function of a different class, we need 
                                           // refer it with the classname
            
            Console.WriteLine(instanceobj.multiply(5, 6));
            Console.Read();
        }
    }
}
