using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTester
{
    [TestClass]
    public class Biltester
    {
        [TestMethod]
        public void Pristester()
        {
            // Arrange 
            Bil biltest = new Bil();

            // Act

            var result = biltest.Pris();

            // Assert
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void Køretøjtester()
        {
            // Arrange 
            Bil biltest = new Bil();

            // Act

            var result = biltest.Køretøj();

            // Assert
            Assert.AreEqual("Bil", result);
        }
    }
}
