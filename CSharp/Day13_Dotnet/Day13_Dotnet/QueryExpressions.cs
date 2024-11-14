using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

        //populate data into the collection

        public static List<Student> GetStudents()
        {
            List<Student> stdList = new List<Student>()
            {
                new Student{ID=101, Name="Mohit", Class="12"},
                new Student{ID=102, Name="Ramya", Class="10"},
                new Student{ID=103, Name="Poormitha", Class="11"},
                new Student{ID=104, Name="Prakruthi", Class="10"},
            };
            return stdList;
        }
    }
    class QueryExpressions
    {
        static void Main()
        {
            int[] intval = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //query expr for finding all odd nos.
            IEnumerable<int> OddNos = from v in intval
                                      where (v % 2) != 0
                                      select v;

            foreach(int x in OddNos)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("QE with User Defined Type");
            //find the Name of the student with ID=103
            //multiple expression options to get the output 
            IEnumerable<Student> s = from stud in Student.GetStudents()
                        where stud.ID == 102
                        select stud;

            IEnumerable<string> sname = from stud in Student.GetStudents()
                                        where stud.ID == 102
                                        select stud.Name;

            var nm = from stud in Student.GetStudents()
                     where stud.ID == 106
                     select stud.Name;

            
            foreach(var n in s)
            {
                Console.WriteLine(n.Name + " " + n.ID) ;
            }
            Console.WriteLine("========================");
            //write a query expression which returns all student names that starts with p

            IEnumerable<string> stdname = from stud in Student.GetStudents()
                                        where stud.Name.StartsWith("P")
                                        select stud.Name;

            foreach (var n in stdname)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("=======================");
            //write a query expression which returns all student names that ends with a

            IEnumerable<string> stdlname = from stud in Student.GetStudents()
                                          where stud.Name.EndsWith("a")
                                          select stud.Name;

            foreach (var n in stdlname)
            {
                Console.WriteLine(n);
            }
            Console.Read();
        }
    }
}
