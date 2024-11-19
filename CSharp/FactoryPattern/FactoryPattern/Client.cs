using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            string cardType = null;
            Console.WriteLine("Enter Card Type :(MB/P/T)");
            cardType = Console.ReadLine();

            ICreditCard cc = CreditCardFactory.GetCreditCard(cardType);
            
            
            if(cc != null)
            {
                Console.WriteLine("Card Type : " + cc.GetCardType());
                Console.WriteLine("Card Limit : " + cc.GetCreditLimit());
                Console.WriteLine("Card Annual Charges : " + cc.GetAnnualCharges());
            }

            else
                Console.WriteLine("Invalid Card.. Try again");
            Console.Read();

        }
    }
}
