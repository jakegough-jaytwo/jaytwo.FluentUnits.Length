using System;
using jaytwo.WeightsAndMeasures;

namespace jaytwo.FluentUnits
{
    public static class ILengthBuilderExtensions
    {
        public static ILengthBuilder AsLength(this decimal value) => new LengthBuilder(value);

        public static ILengthBuilder AsLength(this double value) => new LengthBuilder(value);

        public static ILengthBuilder AsLength(this float value) => new LengthBuilder(value);

        public static ILengthBuilder AsLength(this long value) => new LengthBuilder(value);

        public static ILengthBuilder AsLength(this int value) => new LengthBuilder(value);

        public static Length Meters(this ILengthBuilder builder) => Length.FromMeters(builder.Value);

        public static Length Centimeters(this ILengthBuilder builder) => Length.FromCentimeters(builder.Value);

        public static Length Millimeters(this ILengthBuilder builder) => Length.FromMillimeters(builder.Value);

        public static Length Kilometers(this ILengthBuilder builder) => Length.FromKilometers(builder.Value);

        public static Length Inches(this ILengthBuilder builder) => Length.FromInches(builder.Value);

        public static Length Feet(this ILengthBuilder builder) => Length.FromFeet(builder.Value);

        public static Length Yards(this ILengthBuilder builder) => Length.FromYards(builder.Value);

        public static Length Miles(this ILengthBuilder builder) => Length.FromMiles(builder.Value);
    }
}
