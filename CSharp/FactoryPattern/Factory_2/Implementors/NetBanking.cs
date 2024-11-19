using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_2.Factories;

namespace Factory_2.Implementors
{
    public class NetBanking : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment processing thru Netbanking for an amount of {amount}");
        }
    }
}
