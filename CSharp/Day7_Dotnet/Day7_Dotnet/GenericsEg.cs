using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{
    class GenericsEg
    {
        public static void ListEg()
        {
            List<int> lst = new List<int>();
            lst.Add('a');
            lst.Add(45);
            lst.Add(61);
            lst.Add(8);

            foreach(int x in lst)
            {
                Console.WriteLine(x);
            }

            lst.Sort();


            Console.WriteLine("----------");
            foreach (int x in lst)
            {
                Console.WriteLine(x);
            }

            List<string> lststr = new List<string>();
            lststr.Add("Sriteja");
            lststr.Add("Sainaga");
            lststr.Add("Adisiva");
            lststr.Add("Bhagya");

            lststr.Sort();
            foreach(string s in lststr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------user defined object list------");

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(200, "Nikhil", 50000, "Infinite"));
            emplist.Add(new Employee(130, "Navya", 52000, "Infinite"));
            emplist.Add(new Employee(250, "Sahana", 48000, "Infinite"));
            emplist.Add(new Employee(150, "Rajesh", 50000, "Infinite"));

            foreach (Employee e in emplist)
            {
                Console.WriteLine(e.ToString());                
            }

            emplist.Sort();

            Console.WriteLine("---------After sorting----------");

            IEnumerator<Employee> en = emplist.GetEnumerator();
            while(en.MoveNext())
            {
                Employee item = (Employee)en.Current;
                Console.WriteLine("The Salary is : " + item.Salary);
            }
            
        }
    }

    class Employee : IComparable<Employee>
    {
        int Empid;
        string EmpName;
       public float Salary;
        string Company ;

        public Employee(int id, string name, float sal, string comp)
        {
            Empid = id;
            EmpName = name;
            Salary = sal;
            Company = comp;
        }

        public override string ToString()
        {
            return String.Format("Employee Named : " + EmpName + "  with Id : " + Empid + " Works for " + Company + " and Earns Rs. :" + Salary);
        }

        public int CompareTo(Employee anotherobj)
        {
            if(this.Salary == (anotherobj).Salary)
            {
                return this.Salary.CompareTo(anotherobj.Salary);
            }
            // return anotherobj.Salary.CompareTo(this.Salary); desc sort
            return this.Salary.CompareTo(anotherobj.Salary); //asc sort
        }
    }
}
