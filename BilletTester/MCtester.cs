using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTester
{
    public class MCtester
    {
        [TestMethod]
        public void Pristester()
        {
            // Arrange 
            MC biltest = new MC();

            // Act

            var result = biltest.Pris();

            // Assert
            Assert.AreEqual(125, result);
        }

        [TestMethod]
        public void Køretøjtester()
        {
            // Arrange 
            MC biltest = new MC();

            // Act

            var result = biltest.Køretøj();

            // Assert
            Assert.AreEqual("MC", result);
        }
    }
}