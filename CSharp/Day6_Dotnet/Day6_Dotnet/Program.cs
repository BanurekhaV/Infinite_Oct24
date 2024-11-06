using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Dept { get; set; }
        public string Gender { get; set; }
        
        //let us initialize the properties thru constructor
        public Employee(int ID, string Name,string Job,double Salary, string Dept, string Gender)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Dept = Dept;
            this.Gender = Gender;
        }

        //defining an indexer for the employee class
        public object this[int index]
        {
            //to get the property values 
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Dept;
                else if (index == 5)
                    return Gender;
                else
                    return null;
            }

            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
                else if (index == 4)
                    Dept = value.ToString();
                else if (index == 5)
                    Gender = value.ToString();
            }
        }

        //overloaded indexer

        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "ID")
                    return ID;
                else if (name == "Name")
                    return Name;
                else if (name.ToUpper() == "JOB")
                    return Job;
                else if (name == "Salary")
                    return Salary;
                else if (name == "Dept")
                    return Dept;
                else if (name == "Gender")
                    return Gender;
                else
                    return null;
            }

            set
            {
                if (name == "ID")
                    ID = Convert.ToInt32(value);
                else if (name == "Name")
                    Name = value.ToString();
                else if (name == "Job")
                    Job = value.ToString();
                else if (name == "Salary")
                    Salary = Convert.ToDouble(value);
                else if (name == "Dept")
                    Dept = value.ToString();
                else if (name == "Gender")
                    Gender = value.ToString();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee(101, "Devanshu", "Programmer", 55000, "IT", "Male");

            //try accessing the employee properties using indexers , i.e index position

            Console.WriteLine("EId = " + employee[0]);
            Console.WriteLine("EName = " + employee[1]);
            Console.WriteLine("EJob = " + employee[2]);
            Console.WriteLine("ESalary = " + employee[3]);
            Console.WriteLine("EDept = " + employee[4]);
            Console.WriteLine("EGender = " + employee[5]);

            //let us assign few different values to the properties
            employee[1] = "AjaySairam";
            employee[2] = "Systems Executive";

            Console.WriteLine("======After changes to the Values=======");
            Console.WriteLine("EId = " + employee[0]);
            Console.WriteLine("EName = " + employee[1]);
            Console.WriteLine("EJob = " + employee[2]);
            Console.WriteLine("ESalary = " + employee[3]);
            Console.WriteLine("EDept = " + employee[4]);
            Console.WriteLine("EGender = " + employee[5]);

            Console.WriteLine("--------Calling the overloaded indexer with string index-------");

            Console.WriteLine("EId = " + employee["id"]);
            Console.WriteLine("EName = " + employee["Name"]);
            Console.WriteLine("EJob = " + employee["job"]);
            Console.WriteLine("ESalary = " + employee["Salary"]);
            Console.WriteLine("EDept = " + employee["Dept"]);
            Console.WriteLine("EGender = " + employee["Gender"]);

            Console.Read();
        }
    }
}
