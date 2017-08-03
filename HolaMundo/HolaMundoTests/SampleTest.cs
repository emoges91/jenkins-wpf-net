using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HolaMundoTests
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void SimpleFirstTest()
        {
            Assert.AreEqual("1", "1");
        }

        [TestMethod]
        public void SimpleSecondTest()
        {
            Assert.AreEqual("2", "2");
        }
    }
}
