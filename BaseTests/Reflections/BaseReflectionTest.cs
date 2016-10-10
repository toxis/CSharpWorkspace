using BaseTests.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTests.Reflections
{
    [TestFixture]
    public class BaseReflectionTest
    {
        private Entity<string> _entity;
        private const string HelloReflection = "Hello Reflection";

        [SetUp]
        public void Setup()
        {
            _entity = new Entity<string>();
            _entity.Data = HelloReflection;
        }

        [Test]
        public void PropertyTest()
        {
            var properties = _entity.GetType().GetProperties();
            Assert.AreEqual(properties.Count(), 1);
            var propertyInfo = properties.Single();
            Assert.AreEqual(propertyInfo.Name, nameof(_entity.Data));
            var value = propertyInfo.GetValue(_entity);
            Assert.AreEqual(value, HelloReflection);

            var newValue = "New Value";
            propertyInfo.SetValue(_entity, newValue);
            Assert.AreEqual(newValue, _entity.Data);
        }
    }
}
