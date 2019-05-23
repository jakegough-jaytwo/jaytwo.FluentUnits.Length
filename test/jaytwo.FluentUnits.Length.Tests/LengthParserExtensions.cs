using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace jaytwo.FluentUnits.Tests
{
    public class LengthParserExtensions
    {
        [Theory]
        [InlineData("1 in", 0.0254)]
        [InlineData("1 inch", 0.0254)]
        [InlineData("1 inches", 0.0254)]
        [InlineData("1 ft", 0.3048)]
        [InlineData("1 foot", 0.3048)]
        [InlineData("1 feet", 0.3048)]
        [InlineData("1 yd", 0.9144)]
        [InlineData("1 yard", 0.9144)]
        [InlineData("1 yards", 0.9144)]
        [InlineData("1 mi", 1609.344)]
        [InlineData("1 mile", 1609.344)]
        [InlineData("1 miles", 1609.344)]
        [InlineData("1 mm", 0.001)]
        [InlineData("1 millimeter", 0.001)]
        [InlineData("1 millimeters", 0.001)]
        [InlineData("1 cm", 0.01)]
        [InlineData("1 centimeter", 0.01)]
        [InlineData("1 centimeters", 0.01)]
        [InlineData("1 m", 1)]
        [InlineData("1 meter", 1)]
        [InlineData("1 meters", 1)]
        [InlineData("100 m", 100)]
        [InlineData("1,000 m", 1000)]
        [InlineData("1000.1 m", 1000.1)]
        public void Parse_Length(string value, double expectedMeters)
        {
            // arrange

            // act
            var length = value.Parse().Length();

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters);
        }
    }
}
