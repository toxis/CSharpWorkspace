using System;

namespace BaseTests.Ninject
{
    public class UpperFormatter : IStringFormatter
    {
        public string Format(string input) => input.ToUpper();
    }
}
