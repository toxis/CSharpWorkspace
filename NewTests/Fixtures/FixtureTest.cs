using AutoFixture;

namespace NewTests.Fixtures;

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

        Assert.That(entities.Count(), Is.EqualTo(10));
        foreach (var entity in entities)
        {
            Assert.That(entity.StringProperty, Is.Not.Null);
            Assert.That(entity.IntProperty, Is.Positive.And.GreaterThan(0));
            Assert.That(entity.NotFixtureProperty, Is.EqualTo(nameof(entity.NotFixtureProperty)));
        }
    }
}
