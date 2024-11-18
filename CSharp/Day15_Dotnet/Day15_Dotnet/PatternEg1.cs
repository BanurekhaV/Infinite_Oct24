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

        public static void PrintType(object obj)
        {
            
            switch(obj)
            {
                case Student s:
                    Console.WriteLine($"obj is student and the name is : {s.FName}{s.LName}");
                    break;
                case int i:
                    Console.WriteLine($"obj is an int and the values is :{i}");
                    break;
                    case double d:
                        Console.WriteLine($"obj is a double and the value is {d}");
                    break;
                default:
                    Console.WriteLine("Obj is some unknown type");break;
            }
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

            Console.WriteLine("********************");

            Student.PrintType(35);
            Student.PrintType(stud);
            Student.PrintType(3.14);
            Student.PrintType("Hello");

            Console.WriteLine("******Relational Pattern*******");

            

            
            Console.Read();
        }

        
    }
}
