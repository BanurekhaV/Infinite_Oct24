using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_1
{
    //to avoid tight coupling, we can intoduce an Interface

    public interface IEmployeeDAL
    {
        List<Employee> PopulateEmployees();
    }
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> PopulateEmployees()
        {
            List<Employee> emplist = new List<Employee>
        {
            new Employee(){ID=1, Name = "Suraj", Department="IT"},
             new Employee(){ID=2, Name = "Amish", Department="Admin"},
              new Employee(){ID=3, Name = "Sumithra", Department="HR"},
        };
            return emplist;
        }
    }
}
