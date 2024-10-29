using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class Student
    {
         public float mathsmarks;
         public float sciencemarks;
    }
    class StructVsClass
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.mathsmarks = 93.5f;
            s1.sciencemarks = 90.5f;
            Console.WriteLine(s1.mathsmarks + s1.sciencemarks);

            Student s2 = s1;  // assigning s1 to s2
            Console.WriteLine(s2.mathsmarks + s2.sciencemarks);

            Console.WriteLine("--------After reassigning ------------");
            s1.mathsmarks = 100;
            Console.WriteLine(s1.mathsmarks + s1.sciencemarks);
            Console.WriteLine(s2.mathsmarks + s2.sciencemarks);
            Console.Read();
        }
    }
}
