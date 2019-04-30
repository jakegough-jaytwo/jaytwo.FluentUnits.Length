using System;
using System.Text.RegularExpressions;
using FooLength = jaytwo.FluentUnits.Length;

namespace jaytwo.FluentUnits
{
    public static class ILengthParserExtensions
    {
        public static ILengthParser Parse(this string value) => new LengthParser(value);

        public static FooLength Length(this ILengthParser parser)
        {
            var pattern = "^(?<EXPRESSION>.*)\\s+(?<UNITS>in|inch|inches|ft|foot|feet|yd|yard|yards|mi|mile|miles|m|meter|meters|mm|millimeter|millimeters|cm|centimeter|centimeters|km|kilometer|kilometers)$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            var match = regex.Match(parser.Value);
            var expression = match.Groups["EXPRESSION"].Value;
            var units = match.Groups["UNITS"].Value.ToLowerInvariant();

            var baseValue = decimal.Parse(expression);

            switch (units)
            {
                case "in":
                case "inch":
                case "inches":
                    return FooLength.FromInches(baseValue);

                case "ft":
                case "foot":
                case "feet":
                    return FooLength.FromFeet(baseValue);

                case "yd":
                case "yard":
                case "yards":
                    return FooLength.FromYards(baseValue);

                case "mi":
                case "mile":
                case "miles":
                    return FooLength.FromMiles(baseValue);

                case "m":
                case "meter":
                case "meters":
                    return FooLength.FromMeters(baseValue);

                case "mm":
                case "millimeter":
                case "millimeters":
                    return FooLength.FromMillimeters(baseValue);

                case "cm":
                case "centimeter":
                case "centimeters":
                    return FooLength.FromCentimeters(baseValue);

                case "km":
                case "kilometer":
                case "kilometers":
                    return FooLength.FromKilometers(baseValue);

                default:
                    throw new InvalidOperationException($"Unknown units: {units}");
            }
        }
    }
}
