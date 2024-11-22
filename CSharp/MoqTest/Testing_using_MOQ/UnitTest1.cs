using NUnit.Framework;
using NUnit.Framework.Legacy;
using MoqTest;  //project to test
using Moq;  

namespace Testing_using_MOQ
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testing_AddItems_Tocart()
        {
            //arrange

            var productmock = new Mock<IProductRepository>();
            productmock.Setup(repo => repo.GetByID(1)).Returns(new Products { ID = 1, PName = "Product 1", Price = 200 });
            var sc = new Cart(productmock.Object);

            //Act

            sc.AddItem(1, 2);

            //Assert
            ClassicAssert.AreEqual(1, sc.GetTotalCount());

        }
        
    }
}