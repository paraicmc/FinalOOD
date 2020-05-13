using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using S00188844_ParaicMcDonagh;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncreasePrice()
        {
            //Ex4
            //Arrange
            Phone phone = new Phone();
            double expectedPrice = 500;

            //Act
            phone.IncreasePrice(500, 10);

            //Assert
            Assert.AreEqual(expectedPrice, phone.Price);

        }
    }
}
