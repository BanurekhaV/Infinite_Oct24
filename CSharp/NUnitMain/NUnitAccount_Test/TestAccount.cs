using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnitMain;

namespace NUnitAccount_Test
{
    [TestFixture]
    public class TestAccount
    {
        //arrange 
        Account acc = new Account("12345");

        [Test]
        public void TestDeposit()
        {
            acc.Deposit(1000); //act

             ClassicAssert.AreEqual(1000, acc.checkBalance());
           // ClassicAssert.AreEqual(2000, acc.checkBalance());
        }
         public void TestWithdraw()
         {
            acc.Withdraw(20);
         }

        [Test]
        public void TestWithdrawalException()
        {
            ClassicAssert.Throws<Exception>(TestWithdraw);
        }
    }
}
