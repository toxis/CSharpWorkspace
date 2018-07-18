namespace BaseTests.Ninject
{
    public class LowerFormatter : IStringFormatter
    {
        public string Format(string input) => input.ToLower();
    }
}
