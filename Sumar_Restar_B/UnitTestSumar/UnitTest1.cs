using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarB.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplyTest1()
        {
            //Arrange 
            SumaController MultiplicarController = new SumaController();
            int a = 2;
            int b = 4;
            int esperado = 8;
            //Act
            int r = MultiplicarController.Mul(a, b);
            // Assert
            Assert.AreEqual(r, esperado);
        }
    }
}
