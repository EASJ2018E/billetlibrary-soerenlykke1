using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTester
{
    [TestClass]
    public class Biltester
    {
        [TestMethod]
        public void BilPristester()
        {
            // Arrange 
            Bil biltest = new Bil();

            // Act

            var result = biltest.Pris();

            // Assert
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void BilK�ret�jtester()
        {
            // Arrange 
            Bil biltest = new Bil();

            // Act

            var result = biltest.K�ret�j();

            // Assert
            Assert.AreEqual("Bil", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BilNumberpladetester()
        {
            // Arrange
            Bil biltest = new Bil();
            
            // Act
            biltest.Nummerplade = "123456789";

            // Assert
            Assert.Fail();





        }
    }
}
