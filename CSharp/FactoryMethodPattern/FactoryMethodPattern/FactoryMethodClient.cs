using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class FactoryMethodClient
    {
        static void Main(string[] args)
        {
            CreditCard card = new PlatinumFactory().CreateCard();
            if(card !=null)
            {
                Console.WriteLine("card Type : "+ card.GetCardType());
                Console.WriteLine("Card Limit :" + card.GetCreditLimit());
                Console.WriteLine("Card Charges :" + card.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }

            card = new TitaniumFactory().CreateCard();
            if (card != null)
            {
                Console.WriteLine("card Type : " + card.GetCardType());
                Console.WriteLine("Card Limit :" + card.GetCreditLimit());
                Console.WriteLine("Card Charges :" + card.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }

            card = new MoneyBackFactory().CreateCard();
            if (card != null)
            {
                Console.WriteLine("card Type : " + card.GetCardType());
                Console.WriteLine("Card Limit :" + card.GetCreditLimit());
                Console.WriteLine("Card Charges :" + card.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }

            Console.Read();
        }
    }
}
