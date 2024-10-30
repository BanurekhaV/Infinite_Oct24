using System;


namespace Day3Dotnet
{
    class ReadonlyVsConstants
    {
        //readonly fields
       public readonly int myvar1 = 5;
        readonly int myvar2;
        float f;

        //create constructor
       // public ReadonlyVsConstants() {  } // empty constructor
        public ReadonlyVsConstants(int a, int b) //parameterized constructor
        {
            Console.WriteLine(myvar1 + " " + myvar2);
            myvar1 = a;
            myvar2 = b;
            Console.WriteLine(myvar1 + " " + myvar2);
        }

        static void Main()
        {
            ReadonlyVsConstants rc = new ReadonlyVsConstants(10,20);
            rc.myvar1 = 100;
            rc.myvar2 = 200;
            Console.Read();
        }
    }
}
