using System;


namespace Day3Dotnet
{
    class ReadonlyVsConstants : AccessSpecifiersEg
    {
        //readonly fields
       public readonly int myvar1 = 5;
        public readonly int myvar2;

        //instance or non static field
       public float f = 10.5f;

        //static member  - available as one copy only for the entire class. Values can be changed
        static public int st = 99;

        //constant field

        const float Pi = 3.14f;  //values to be assigned to const field at the time of decl. itself
        //create constructor
       // public ReadonlyVsConstants() {  } // empty constructor
        public ReadonlyVsConstants(int a, int b) //parameterized constructor
        {
            Console.WriteLine(myvar1 + " " + myvar2);
            myvar1 = a;
            myvar2 = b;
            Console.WriteLine(myvar1 + " " + myvar2 + " " + f);
        }

        static void Main()
        {
            //ReadonlyVsConstants rc = new ReadonlyVsConstants(10,20);
            ////Console.WriteLine(rc);
            //Console.WriteLine(rc.myvar1 + " " + rc.myvar2 + " " + rc.f + " " + st + " " + Pi);
            //rc.f = 45.5f;
            //ReadonlyVsConstants rc2 = new ReadonlyVsConstants(50, 100);
            //rc2.f = 125.6f;
            //st = 199;

            //Console.WriteLine(rc2.myvar1 +  " " +rc2.myvar2  + " " + rc2.f + " " + st + " " + Pi);
            // Console.WriteLine("----------OO concepts--------");
            //Employee employee1 = new Employee();  // calling an empty constructor
            //employee1 = null;  // setting an object to null calls a destructor if available
            // GC.Collect();  // forcing the garbage collector to release memory immediately
            //Employee employee2 = new Employee(100, "Hari"); //calling a 2 parameter constructor
            Console.WriteLine("---------AccessSpecifiers Example----------");

            AccessSpecifiersEg aeg = new AccessSpecifiersEg();
            aeg.acceptdata();
            aeg.showdata();
            aeg.publicmember = 200;
            aeg.showdata();
            aeg.internalmember = 2000;
            aeg.showdata();
            aeg.pimember = 9;
            //protected members of the base class are accesible from the derived class objects only
            ReadonlyVsConstants rc = new ReadonlyVsConstants(1, 2);
            rc.protectedmember = 10001;
            rc.showdata();
            rc.pimember = 19;
            Console.Read();
        }
    }
}
