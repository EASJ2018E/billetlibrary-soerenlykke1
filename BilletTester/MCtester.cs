using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTester
{   
    [TestClass]
    public class MCtester
    {
        [TestMethod]
        public void MCPristester()
        {
            // Arrange 
            MC mctest = new MC();

            // Act

            var result = mctest.Pris();

            // Assert
            Assert.AreEqual(125, result);
        }

        [TestMethod]
        public void MCKøretøjtester()
        {
            // Arrange 
            MC mctest = new MC();

            // Act

            var result = mctest.Køretøj();

            // Assert
            Assert.AreEqual("MC", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MCNummerpladetester()
        {
            // Arrange
            MC mctest = new MC();

            // Act
            mctest.Nummerplade = "12345678";

            // Assert
            Assert.Fail();
        }
    }
}