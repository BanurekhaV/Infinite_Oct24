using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Platinum : ICreditCard
    {
        public int GetAnnualCharges()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public double GetCreditLimit()
        {
            return 35000;
        }
    }
}
