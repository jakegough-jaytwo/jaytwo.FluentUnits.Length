using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace jaytwo.FluentUnits.Tests
{
    public class LengthBuilderExtensionsTests
    {
        [Fact]
        public void Inches()
        {
            // arrange
            var inchesPerMile = 63360;

            // act
            var length = inchesPerMile.AsLength().Inches();

            // assert
            Assert.Equal(1m, length.Miles);
        }

        [Fact]
        public void Feet()
        {
            // arrange
            var feetPerMile = 5280;

            // act
            var length = feetPerMile.AsLength().Feet();

            // assert
            Assert.Equal(1m, length.Miles);
        }

        [Fact]
        public void Yards()
        {
            // arrange
            var feetPerMile = 1760;

            // act
            var length = feetPerMile.AsLength().Yards();

            // assert
            Assert.Equal(1m, length.Miles);
        }

        [Fact]
        public void Miles()
        {
            // arrange
            var milesPerMile = 1;

            // act
            var length = milesPerMile.AsLength().Miles();

            // assert
            Assert.Equal(1m, length.Miles);
        }

        [Fact]
        public void Millimeters()
        {
            // arrange
            var millimetersPerMile = 1609344;

            // act
            var length = millimetersPerMile.AsLength().Millimeters();

            // assert
            Assert.Equal(1m, length.Miles);
        }

        [Fact]
        public void Centimeters()
        {
            // arrange
            var centimetersPerMile = 160934.4;

            // act
            var length = centimetersPerMile.AsLength().Centimeters();

            // assert
            Assert.Equal(1m, length.Miles);
        }

        [Fact]
        public void Meters()
        {
            // arrange
            var metersPerMile = 1609.344;

            // act
            var length = metersPerMile.AsLength().Meters();

            // assert
            Assert.Equal(1m, length.Miles);
        }

        [Fact]
        public void Kilometers()
        {
            // arrange
            var kilometersPerMile = 1.609344;

            // act
            var length = kilometersPerMile.AsLength().Kilometers();

            // assert
            Assert.Equal(1m, length.Miles);
        }
    }
}
