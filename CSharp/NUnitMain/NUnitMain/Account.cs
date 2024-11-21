using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitMain
{
    public class Account
    {
        string accountno;
        float balance ;
        public List<Account> transferaccount;

        public Account(string accno)
        {
            this.accountno = accno;
            transferaccount = new List<Account>();
        }

        public float checkBalance()
        {
            return balance;
        }

        public void Deposit(float amt)
        {
            balance += amt;
        }

        public void Withdraw(float amt)
        {
            if (balance >= amt)
                balance -= amt;
            else
                throw new Exception("Not Enough Funds");
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }

        public List<Employee>Empdata()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID=100, Name="Aarthi", Gender="Female", Salary=45000},
                new Employee{ID=101, Name="BhanuPrakash", Gender="Male", Salary=45000},
                new Employee{ID=102, Name=null, Gender="Male", Salary=45000},
            };
            return emplist;
        }

        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "User Id or Password cannot be empty";
            }
            else if (userid == "Admin" && password == "Admin@123")
            {
                return "Welcome Admin";
            }
            else
                return "Incorrect UserId or Password";
        }

        public int Add2Nos(int x, int y)
        {
            return x + y;
        }
    }
}
