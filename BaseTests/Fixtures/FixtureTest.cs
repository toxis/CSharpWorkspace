using AutoFixture;
using NFluent;
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

            Check.That(entities).CountIs(10);
            foreach (var entity in entities)
            {
                Check.That(entity.StringProperty).IsNotNull();
                Check.That(entity.IntProperty).IsStrictlyPositive().And.IsStrictlyGreaterThan(0);
                Check.That(entity.NotFixtureProperty).IsEqualTo(nameof(entity.NotFixtureProperty));
            }
        }
    }
}
