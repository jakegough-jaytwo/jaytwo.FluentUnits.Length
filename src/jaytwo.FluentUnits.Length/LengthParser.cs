using System;

namespace jaytwo.FluentUnits
{
    public class LengthParser : ILengthParser
    {
        public LengthParser(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
