using System;

namespace jaytwo.FluentUnits
{
    public class LengthParser : ILengthParser
    {
        public string Value { get; }

        public LengthParser(string value)
        {
            Value = value;
        }
    }
}
