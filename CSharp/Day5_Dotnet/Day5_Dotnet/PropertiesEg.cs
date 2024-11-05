using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    class Student
    {
        string code = "N.A";
        string name = "Unknown";
        int age = 0;
       // public int Age { get; } = 22; //declaration of automatic properties

        //let us declare properties for the above fields
        public string Code
        {
            get {return code; }
           // set {; }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    name = "Empty or Null";
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + code + " Name = " + name + " Age = " + age;           
        }
    }
    class PropertiesEg
    {
        static void Main()
        {
            Student stud = new Student();
           // Console.WriteLine(stud.Code);
           // Console.WriteLine(stud.Name);
            stud.Name = null;
            // Console.WriteLine(stud.Name);
            stud.Age += 1;
            Console.WriteLine("Students Info. {0}",stud.ToString());

            Console.Read();
        }
    }
}
