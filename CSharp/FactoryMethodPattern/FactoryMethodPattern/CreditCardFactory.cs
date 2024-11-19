using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //creator class
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeCard();

        public virtual CreditCard CreateCard()
        {
            CreditCard creditcard = this.MakeCard();
            return creditcard;
        }
    }
}
