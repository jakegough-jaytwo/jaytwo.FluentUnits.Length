using System;

namespace jaytwo.FluentUnits
{
    public class LengthBuilder : ILengthBuilder
    {
        public LengthBuilder(decimal value)
        {
            Value = value;
        }

        public LengthBuilder(double value)
            : this(Convert.ToDecimal(value))
        {
        }

        public LengthBuilder(long value)
            : this(Convert.ToDecimal(value))
        {
        }

        public decimal Value { get; }
    }
}
