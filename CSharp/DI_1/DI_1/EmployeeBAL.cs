using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_1
{
    public class EmployeeBAL
    {
        public IEmployeeDAL empdal;

        //for DI in the property
        public IEmployeeDAL Empobj
        {
            set
            {
                this.empdal = value;
            }
        }

        //Injecting DI object using the constructor - (loose coupling)

        //public EmployeeBAL(IEmployeeDAL iedal)
        //{
        //    this.empdal = iedal;
        //}

        public EmployeeBAL() { }

        public List<Employee> GetAllEmployees()
        {
            return empdal.PopulateEmployees();
        }
        //instead of the above constructor, if we want to inject in the below method

        //public List<Employee> GetAllEmployees(IEmployeeDAL empdal)
        //{
        //    return empdal.PopulateEmployees();
        //}
    }
}
