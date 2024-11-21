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

        //Injecting DI object using the constructor - (loose coupling)

        public EmployeeBAL(IEmployeeDAL iedal)
        {
            this.empdal = iedal;
        }
        public List<Employee>GetAllEmployees()
        {
            return empdal.PopulateEmployees();
        }
    }
}
