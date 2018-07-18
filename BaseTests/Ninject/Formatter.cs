namespace BaseTests.Ninject
{
    public class Formatter
    {
        private readonly IStringFormatter _formatter;

        public Formatter(IStringFormatter formatter)
        {
            _formatter = formatter;
        }

        public string Handle(string input)
        {
            return _formatter.Format(input);
        }
    }
}
