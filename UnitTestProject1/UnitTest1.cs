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
            double expectedPrice = 550;

            //Act
            phone.IncreasePrice(500, .1);

            //Assert
            Assert.AreEqual(expectedPrice, phone.Price);

        }
    }
}
