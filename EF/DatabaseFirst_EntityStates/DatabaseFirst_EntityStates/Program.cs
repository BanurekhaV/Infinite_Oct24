using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst_EntityStates
{
    class Program
    {
        //let us create an instance of the database Context class

        static InfiniteDBEntities db = new InfiniteDBEntities();

       static  tblEmployee emp1 = new tblEmployee();
        static void Main(string[] args)
        {           
            Console.WriteLine("******Entity States*******");
           
            Console.WriteLine($"State of the newly created Entity Object : {db.Entry(emp1).State}");

            emp1.EmpId = 1001;
            emp1.EmpName = "Hannah";
            emp1.Gender = "Female";
            emp1.Salary = 15000;
            emp1.Phoneno = "1111111";
            emp1.DeptId = null;

            Console.WriteLine("-------Insertion---------");
            AddEmp(emp1);
            ShowEmployees();
            Console.WriteLine("---------Updation----------");
            UpdateEmp();
            ShowEmployees();
            Console.WriteLine("---------Deletion----------");
            DeleteEmp();
            ShowEmployees();
            Console.Read();
        }

        static void ShowEmployees()
        {
            var emp = db.tblEmployees.ToList();

            foreach (var item in emp)
            {
                Console.WriteLine($"Employee : {item.EmpName} Earns a Salary of : {item.Salary}, and works for Department: {item.DeptId}");
            }
        }
        static void AddEmp(tblEmployee e)
        {
            Console.WriteLine($"Before Addition or Insertion , The State of the Entity : {db.Entry(e).State}");
            db.tblEmployees.Add(e);
            Console.WriteLine($"Before Save Changes is Called , The State of the Entity : {db.Entry(e).State}");
            db.SaveChanges(); // this function ensures the changes to the entity are made to the database
            Console.WriteLine($"After Save Changes is Called , The State of the Entity : {db.Entry(e).State}");
        }

        static void UpdateEmp()
        {
            Console.WriteLine("Enter Empid to update :");
            int eid = Convert.ToInt32(Console.ReadLine());
            emp1 = db.tblEmployees.Find(eid);
            

            if(emp1!=null)
            {
                Console.WriteLine($"Before Update , The State of the Entity : {db.Entry(emp1).State}");
                emp1.DeptId = 5;
                Console.WriteLine($"After Updation, The State of the Entity : {db.Entry(emp1).State}");
                db.SaveChanges();
                Console.WriteLine($"After Save Changes, The State of the Entity : {db.Entry(emp1).State}");
            }
            else
            {
                Console.WriteLine("Matching Employee not found..");
            }
        }

        static void DeleteEmp()
        {
            Console.WriteLine("Enter Empid to Delete :");
            int eid = Convert.ToInt32(Console.ReadLine());
            emp1 = db.tblEmployees.Find(eid);

            if (emp1 != null)
            {
                Console.WriteLine($"Before Deletion, The State of the Entity : {db.Entry(emp1).State}");
                db.tblEmployees.Remove(emp1);
                Console.WriteLine($"After Deletion, The State of the Entity : {db.Entry(emp1).State}");
                db.SaveChanges();
                Console.WriteLine($"After calling SaveChanges, The State of the Entity : {db.Entry(emp1).State}");
            }
            else
            {
                Console.WriteLine("Matching Employee not found to delete");
            }
        }
    }
}
