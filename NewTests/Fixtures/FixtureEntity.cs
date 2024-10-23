namespace NewTests.Fixtures;

public class FixtureEntity
{
    public string StringProperty { get; set; }
    public int IntProperty { get; set; }
    public string NotFixtureProperty { get; set; } = nameof(NotFixtureProperty);
}
