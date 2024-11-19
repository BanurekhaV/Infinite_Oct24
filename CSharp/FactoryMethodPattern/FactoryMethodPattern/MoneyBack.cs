﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class MoneyBack : CreditCard
    {
        
            public int GetAnnualCharges()
            {
                return 500;
            }

            public string GetCardType()
            {
                return "Money Back";
            }

            public double GetCreditLimit()
            {
                return 15000;
            }
        }

    }

