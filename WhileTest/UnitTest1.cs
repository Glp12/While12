using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using While;
namespace WhileTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AZEro()
        {
            int a = 0;
            int expected = 0;

            wh c = new wh();
            int result = c.While8(a);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AMin()
        {
            int a = -2;
            int expected = 0;

            wh c = new wh();
            int result = c.While8(a);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void RightAn()
        {
            int a = 2;
            int expected = 2;

            wh c = new wh();
            int result = c.While8(a);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AMinZEro()
        {
            int a = -2;
            int expected = 0;

            wh c = new wh();
            int result = c.While12(a);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void RightAns()
        {
            int a = 3;
            int expected = 2;

            wh c = new wh();
            int result = c.While12(a);

            Assert.AreEqual(expected, result);
        }
    }
}
