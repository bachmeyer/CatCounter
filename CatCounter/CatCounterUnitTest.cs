using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatCounter
{
    [TestClass]
    public class CatCounterUnitTest
    {
        [TestMethod]
        public void TestCatInString()
        {
            var cats = new CatCounterClass();
            var result = cats.CatCounter("hey there cat");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestCatNoSpaces()
        {
            var cats = new CatCounterClass();
            var result = cats.CatCounter("catcatcatcat");
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestCatNoCat()
        {
            var cats = new CatCounterClass();
            var result = cats.CatCounter("I am a dog");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestCatUpperCase()
        {
            var cats = new CatCounterClass();
            var result = cats.CatCounter("there goes that Cat");
            Assert.AreEqual(1, result);
        }
    }
}
