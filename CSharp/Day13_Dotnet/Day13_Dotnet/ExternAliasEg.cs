extern alias X;
extern alias Y;

using System;
using System.Collections.Generic;


namespace Day13_Dotnet
{
    class ExternAliasEg
    {
        public static void Main()
        {
            var obj1 = new X.ClassLibrary1.MyExternClass();
            var obj2 = new Y.ClassLibrary2.MyExternClass();
            X.ClassLibrary1.MyExternClass.num = 5;
            Y.ClassLibrary2.MyExternClass.num = 10;

            Console.WriteLine(X.ClassLibrary1.MyExternClass.num);
            Console.WriteLine(Y.ClassLibrary2.MyExternClass.num);

            obj1.MyExternFunction(); 
            obj2.MyExternFunction();
            
            Console.Read();
        }
    }
}
