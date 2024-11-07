using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{
    class ComparisionEg
    {
        static void Main()
        {
            string[] fruits = { "Oranges", "Grapes", "Bananas", "Guavas", "Apples" };
            Array.Sort(fruits);

            foreach(string f in fruits)
            {
                Console.WriteLine(f);
            }

            Student.compareStudentsName();
            Console.Read();
        }
    }

    class Student :IComparable
    {
        public string Name { get; set;}
        public int TotalMarks { get; set;}

        public static void compareStudentsName()
        {
            // Single object initialization without constructor
          //  Student s = new Student {Name = "Suchitha", TotalMarks = 89 };

            //Array object initialization without constructors
            Student[] stud = new Student[] 
            {
                 new Student {Name= "Somasekhar", TotalMarks=90},
                 new Student {Name= "Bhuvaneshwaran", TotalMarks=91},
                 new Student {Name= "Shreepriya", TotalMarks=80},
                 new Student {Name= "Aadi", TotalMarks=89}
            };

            Array.Sort(stud);
            Console.WriteLine("-------Sorted User Defined Object-------");
            foreach(var s in stud)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine("-----Sorted marks using IComparer----");

            Marks m = new Marks();
            Student s1 = new Student { Name = "Saikeerthi", TotalMarks = 92 };
            Student s2 = new Student { Name = "Senbagam", TotalMarks = 90 };

           int answer = m.Compare(s1,s2);
            if (answer ==1) Console.WriteLine("Student one has more marks");
            else Console.WriteLine("student 2 has more marks");
        }

        public int CompareTo(object obj)
        {
            Student sobj = obj as Student;
            if(sobj !=null)
            {
                // return this.Name.CompareTo(sobj.Name);
                return sobj.Name.CompareTo(this.Name);
            }
            return -2;
        }
    }

    class Marks : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.TotalMarks.CompareTo(y.TotalMarks);            
        }

        public static void JustLikeThat()
        {
            string name ;
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();
            if (name.Trim().Equals(string.Empty))
            {
                throw new Exception("Name Cannot be blank"); //avoid throwing base class object 
            }
            else
                Console.WriteLine(name.ToUpper());
        }
    }
}
