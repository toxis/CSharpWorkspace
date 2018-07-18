using AutoFixture;
using NUnit.Framework;
using System;
using System.Linq;

namespace BaseTests.Fixtures
{
    [TestFixture]
    public class FixtureTest
    {
        [Test]
        public void ShouldReplaceDefaultValues()
        {
            var fixture = new Fixture();
            
            var entities = fixture.Build<FixtureEntity>()
                .Without(e => e.NotFixtureProperty)
                .CreateMany(10);
            Assert.AreEqual(10, entities.Count());
            
            foreach (var entity in entities)
            {
                Assert.NotNull(entity.StringProperty);
                Assert.AreNotEqual(0, entity.IntProperty);
                Assert.AreEqual(nameof(entity.NotFixtureProperty), entity.NotFixtureProperty);
            }
        }
    }
}
