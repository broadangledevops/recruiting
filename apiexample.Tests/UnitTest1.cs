using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apiexample.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            int y = 2;
            int z = x + y;

            Assert.AreEqual(3,z);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int x = 1;
            int y = 2;
            int z = x + y;

            Assert.AreEqual(4, z);
        }

    }
}
