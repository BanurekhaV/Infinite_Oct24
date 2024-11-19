using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_2.Factories;

namespace Factory_2
{
    class Client2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a Payment Gateway (Wallet / Netbanking / COD");
            string pname = Console.ReadLine();

            try
            {
                IPaymentGateway pg = PaymentGatewayFactory.CreatePaymentGateway(pname);
                pg.ProcessPayment(2500.50m);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.Read();
        }
    }
}
