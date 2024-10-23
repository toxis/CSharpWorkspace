namespace NewTests.DependencyInjection;

public class UpperStringFormatter : IStringFormatter
{
    public string Format(string input) => input.ToUpper();
}
