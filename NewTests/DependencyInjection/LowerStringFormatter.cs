namespace NewTests.DependencyInjection;

public class LowerStringFormatter : IStringFormatter
{
    public string Format(string input) => input.ToLower();
}
