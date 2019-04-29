using System;

namespace jaytwo.FluentUnits
{
    public static class LengthExtensions
    {
        public static Length MultiplyBy(this Length length, decimal value) => length * value;
        public static Length MultiplyBy(this Length length, double value) => length * value;
        public static Length MultiplyBy(this Length length, long value) => length * value;
        public static Length DivideBy(this Length length, decimal value) => length / value;
        public static Length DivideBy(this Length length, double value) => length / value;
        public static Length DivideBy(this Length length, long value) => length / value;
        public static Length Add(this Length length, Length lengthToAdd) => length + lengthToAdd;
        public static Length Subtract(this Length length, Length lengthToSubtract) => length - lengthToSubtract;

        public static Length LengthMillimeters(this decimal value) => Length.FromMillimeters(value);
        public static Length LengthMillimeters(this double value) => Length.FromMillimeters(value);
        public static Length LengthMillimeters(this float value) => Length.FromMillimeters(value);
        public static Length LengthMillimeters(this long value) => Length.FromMillimeters(value);
        public static Length LengthMillimeters(this int value) => Length.FromMillimeters(value);
        public static Length LengthCentimeters(this decimal value) => Length.FromCentimeters(value);
        public static Length LengthCentimeters(this double value) => Length.FromCentimeters(value);
        public static Length LengthCentimeters(this float value) => Length.FromCentimeters(value);
        public static Length LengthCentimeters(this long value) => Length.FromCentimeters(value);
        public static Length LengthCentimeters(this int value) => Length.FromCentimeters(value);
        public static Length LengthMeters(this decimal value) => Length.FromMeters(value);
        public static Length LengthMeters(this double value) => Length.FromMeters(value);
        public static Length LengthMeters(this float value) => Length.FromMeters(value);
        public static Length LengthMeters(this long value) => Length.FromMeters(value);
        public static Length LengthMeters(this int value) => Length.FromMeters(value);
        public static Length LengthKilometers(this decimal value) => Length.FromKilometers(value);
        public static Length LengthKilometers(this double value) => Length.FromKilometers(value);
        public static Length LengthKilometers(this float value) => Length.FromKilometers(value);
        public static Length LengthKilometers(this long value) => Length.FromKilometers(value);
        public static Length LengthKilometers(this int value) => Length.FromKilometers(value);

        public static Length LengthInches(this decimal value) => Length.FromInches(value);
        public static Length LengthInches(this double value) => Length.FromInches(value);
        public static Length LengthInches(this float value) => Length.FromInches(value);
        public static Length LengthInches(this long value) => Length.FromInches(value);
        public static Length LengthInches(this int value) => Length.FromInches(value);
        public static Length LengthFeet(this decimal value) => Length.FromFeet(value);
        public static Length LengthFeet(this double value) => Length.FromFeet(value);
        public static Length LengthFeet(this float value) => Length.FromFeet(value);
        public static Length LengthFeet(this long value) => Length.FromFeet(value);
        public static Length LengthFeet(this int value) => Length.FromFeet(value);
        public static Length LengthYards(this decimal value) => Length.FromYards(value);
        public static Length LengthYards(this double value) => Length.FromYards(value);
        public static Length LengthYards(this float value) => Length.FromYards(value);
        public static Length LengthYards(this long value) => Length.FromYards(value);
        public static Length LengthYards(this int value) => Length.FromYards(value);
        public static Length LengthMiles(this decimal value) => Length.FromMiles(value);
        public static Length LengthMiles(this double value) => Length.FromMiles(value);
        public static Length LengthMiles(this float value) => Length.FromMiles(value);
        public static Length LengthMiles(this long value) => Length.FromMiles(value);
        public static Length LengthMiles(this int value) => Length.FromMiles(value);
    }
}
