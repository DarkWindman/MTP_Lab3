using System;
using Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
         [TestMethod]
        public void TestCopy1()
        {
            var bus = new Bus("maz-105", "074-21 KA", new Park(4705)); 
            var result = bus.ShallowCopy();
            var expected = new Bus("maz-105", "074-21 KA", new Park(4705));
            Assert.AreEqual(result.model, expected.model);
            Assert.AreEqual(result.nubmer, expected.nubmer);
            Assert.AreEqual(bus.id.id, result.id.id); 
        }

        [TestMethod]
        public void TestCopy2()
        {
            var bus = new Bus("maz-103", "AA0715AA", new Park(1863));
            var result = bus.DeepCopy();
            var expected = new Bus("maz-103", "AA0715AA", new Park(1863));
            Assert.AreEqual(result.model, expected.model);
            Assert.AreEqual(result.nubmer, expected.nubmer);
            Assert.AreEqual(result.id.id, expected.id.id);

        }
    }
}
