﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
   public interface CreditCard
    {
        string GetCardType();
        int GetAnnualCharges();
        double GetCreditLimit();
    }
}
