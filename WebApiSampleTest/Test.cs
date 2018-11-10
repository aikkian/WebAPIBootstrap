using NUnit.Framework;
using System;
namespace WebApiSampleTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(true, false, "Test Failed", null);
        }
    }
}
