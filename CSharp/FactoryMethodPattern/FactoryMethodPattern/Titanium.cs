using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
   public class Titanium: CreditCard
    {
        public int GetAnnualCharges()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public double GetCreditLimit()
        {
            return 25000;
        }

    }
}
