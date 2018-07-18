using NUnit.Framework;
using Moq;
using NFluent;

namespace BaseTests.Moq
{
    [TestFixture]
    public class MoqTest
    {
        [Test]
        public void MultiplyCalculatorTest()
        {
            var calculator = Mock.Of<MoqCalculator>(c => c.Multiply(2, 2) == 4);
            Check.That(calculator.Pow2(2)).IsEqualTo(4);
            // Be sure that Multiply method was called in Pow2 method
            Mock.Get(calculator).Verify(c => c.Multiply(2, 2));
        }
    }
}
