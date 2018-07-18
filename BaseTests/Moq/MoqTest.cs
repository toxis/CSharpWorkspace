using NUnit.Framework;
using Moq;

namespace BaseTests.Moq
{
    [TestFixture]
    public class MoqTest
    {
        [Test]
        public void MultiplyCalculatorTest()
        {
            var mockCalculator = new Mock<MoqCalculator>();
            mockCalculator.Setup(c => c.Multiply(2, 2)).Returns(4);
            Assert.AreEqual(4, mockCalculator.Object.Pow2(2));
        }
    }
}
