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
        Account acc;

        [SetUp]
        
        public void ArrangeData()
        {
            acc = new Account("12345");
        }

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

        [Test]
        public void Testing_Login()
        {
            //arrange

            Employee emp = new Employee();

            //act
            string s1 = emp.Login("Banurekha", "AAA");
            string s2 = emp.Login("", "");
            string s3 = emp.Login("Admin", "Admin@123");

            //assert
            ClassicAssert.AreEqual("User Id or Password cannot be empty", s2);
            ClassicAssert.AreEqual("Incorrect UserId or Password", s1);
            ClassicAssert.AreEqual("Welcome Admin", s3);
        }

        [Test]
        [TestCase(15,35,60)]
        [TestCase(10,45,55)]
        [TestCase(20,50,70)]

        public void TestingAdd2Nos_withTestcases(int n1, int n2, int expected)
        {
            Employee e = new Employee(); //arrange
            int res = e.Add2Nos(n1, n2);
            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [Ignore("waitforsometime")]

        public void TestemployeeDetails()
        {
            Employee e = new Employee();
            List<Employee> elist = e.Empdata();

            foreach(var x in elist)
            {
                ClassicAssert.IsNotNull(x.ID);
                ClassicAssert.IsNotNull(x.Name);
            }
        }

        //testing reservation/user class
        [Test]
        public void CancellationByAdmin_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void CancellationByBookedBy_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { BookedBy = user };

            var result = reservation.CanBeCancelledBy(user);

            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void Cancellation_MadeBy_Others_ReturnFalse()
        {
            var reservation = new Reservation { BookedBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
            ClassicAssert.IsFalse(result);
        }
    }
}
