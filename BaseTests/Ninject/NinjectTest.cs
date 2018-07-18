using NFluent;
using Ninject;
using NUnit.Framework;
using System.Reflection;

namespace BaseTests.Ninject
{
    [TestFixture]
    public class NinjectTest
    {
        [Test]
        public void UpperDependancyModule()
        {
            var kernel = new StandardKernel(new UpperModule());
            var formatter = kernel.Get<Formatter>();
            Check.That(formatter.Handle("hello")).IsEqualTo("HELLO");
        }

        [Test]
        public void LowerDependancyModule()
        {
            var kernel = new StandardKernel(new LowerModule());
            var formatter = kernel.Get<Formatter>();
            Check.That(formatter.Handle("HELLO")).IsEqualTo("hello");
        }
    }
}
