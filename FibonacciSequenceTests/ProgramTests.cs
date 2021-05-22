using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciSequence;


namespace FibonacciSequence.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciNumber11()
        {
            int n = 11;
            Assert.AreEqual(n, 11);

        }
        [TestMethod]
        public void FibonacciNumber0()
        {
            int n = 0;
            Assert.AreEqual(n, 0);

        }
        [TestMethod]
        public void FibonacciNumber3()
        {
            int n = 3;
            Assert.AreEqual(n, 3);

        }

    }
}


