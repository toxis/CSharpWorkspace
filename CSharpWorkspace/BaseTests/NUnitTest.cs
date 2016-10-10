using System;
using NUnit.Framework;

namespace BaseTests
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void TestMethod()
        {
            Assert.That(true == true);
        }
    }
}
