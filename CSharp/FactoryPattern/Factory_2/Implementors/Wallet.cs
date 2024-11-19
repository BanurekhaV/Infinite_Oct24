using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_2.Factories;

namespace Factory_2.Implementors
{
    class Wallet : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($" processing payment amount {amount} thru Wallet...");
        }
    }
    

}
