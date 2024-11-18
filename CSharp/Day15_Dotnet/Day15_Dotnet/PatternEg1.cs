using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class Student
    {
        public string FName { get; private set; }
        public string LName { get; private set; }

        public Student(string fn, string ln)
        {
            this.FName = fn;
            this.LName = ln;
        }
    }
    class PatternEg1
    {
        static void Main()
        {
            Student stud = new Student("Amitabh", "Bacchan");
            Student st = null;
            int? a = 25;
           // switch(stud)
          // switch(st)
            switch(a)
            {
                case null: Console.WriteLine("Constant Pattern");break;
               // case Student s when s.FName.StartsWith("A"): Console.WriteLine(s.FName);break;
                case var x: Console.WriteLine(x?.GetType().Name);break;
            }
            Console.Read();
        }
    }
}
