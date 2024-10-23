using NewTests.Common;

namespace NewTests.Reflections;

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
        Assert.That(properties.Count(), Is.EqualTo(1));

        var propertyInfo = properties.Single();
        Assert.That(propertyInfo.Name, Is.EqualTo(nameof(_entity.Data)));
        var value = propertyInfo.GetValue(_entity);
        Assert.That(value, Is.EqualTo(HelloReflection));

        var newValue = "New Value";
        propertyInfo.SetValue(_entity, newValue);
        Assert.That(newValue, Is.EqualTo(_entity.Data));
    }
}
