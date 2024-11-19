using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeCard()
        {
            CreditCard card = new Platinum();
            return card;
        }
    }
}
