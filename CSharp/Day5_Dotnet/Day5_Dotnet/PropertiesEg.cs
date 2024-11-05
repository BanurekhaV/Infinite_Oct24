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
    }
    class PropertiesEg
    {
        static void Main()
        {
            Student stud = new Student();
            Console.WriteLine(stud.Code);
            Console.WriteLine(stud.Name);
            stud.Name = null;
            Console.WriteLine(stud.Name);
            Console.Read();
        }
    }
}
