using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeCard()
        {
            CreditCard card = new MoneyBack();
            return card;
        }

        //public override CreditCard CreateCard()
        //{
        //    return base.CreateCard();
        //}
    }
}
