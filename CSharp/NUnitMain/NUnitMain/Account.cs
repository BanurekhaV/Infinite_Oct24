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
}
