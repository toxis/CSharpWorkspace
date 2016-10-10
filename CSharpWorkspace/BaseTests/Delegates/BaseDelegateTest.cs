using System;
using NUnit.Framework;
using BaseTests.Common;

namespace BaseTests.Delegates
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void DelegateTest()
        {
            var entity = new Entity<string>();
            var initString = default(string);
            Assert.AreEqual(entity.Data, initString);

            var oldValue = initString;
            var newValue = "New Value";
            entity.ValueChanged += (s, e) =>
            {
                Assert.AreEqual(e.OldValue, oldValue);
                Assert.AreEqual(e.NewValue, newValue);
            };

            entity.Data = newValue;
        }
    }
}
