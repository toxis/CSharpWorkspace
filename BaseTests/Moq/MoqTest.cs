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
            var calculator = Mock.Of<MoqCalculator>(c => c.Multiply(2, 2) == 4);
            Assert.AreEqual(4, calculator.Pow2(2));
            // Be sure that Multiply method was called in Pow2 method
            Mock.Get(calculator).Verify(c => c.Multiply(2, 2));
        }
    }
}
