using NewTests.Common;

namespace NewTests.Delegates;

public class BaseDelegateTest
{
    [Test]
    public void EventHandlerTest()
    {
        var entity = new Entity<string>();
        var initString = default(string);
        Assert.That(entity.Data, Is.EqualTo(initString));

        var oldValue = initString;
        var newValue = "New Value";
        entity.ValueChanged += (s, e) =>
        {
            Assert.That(e.OldValue, Is.EqualTo(oldValue));
            Assert.That(e.NewValue, Is.EqualTo(newValue));
        };

        entity.Data = newValue;
    }
}
