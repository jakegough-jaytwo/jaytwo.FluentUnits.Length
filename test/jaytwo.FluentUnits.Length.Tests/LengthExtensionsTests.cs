using System;
using Xunit;

namespace jaytwo.FluentUnits.Tests
{
    // as defined in the NSIT Handbook 44
    // https://nvlpubs.nist.gov/nistpubs/hb/2019/NIST.HB.44-2019.pdf
    // page C-8

    public class LengthExtensionsTests
    {
        [Fact]
        public void LengthMillimeters()
        {
            // arrange
            var metersPerMillimeter = .001m;

            // act & assert
            Assert.Equal(metersPerMillimeter, 1m.LengthMillimeters().Meters);
            Assert.Equal(metersPerMillimeter, 1d.LengthMillimeters().Meters);
            Assert.Equal(metersPerMillimeter, 1f.LengthMillimeters().Meters);
            Assert.Equal(metersPerMillimeter, 1.LengthMillimeters().Meters);
            Assert.Equal(metersPerMillimeter, 1L.LengthMillimeters().Meters);
        }

        [Fact]
        public void LengthCentimeters()
        {
            // arrange
            var metersPerCentimeter = .01m;

            // act & assert
            Assert.Equal(metersPerCentimeter, 1m.LengthCentimeters().Meters);
            Assert.Equal(metersPerCentimeter, 1d.LengthCentimeters().Meters);
            Assert.Equal(metersPerCentimeter, 1f.LengthCentimeters().Meters);
            Assert.Equal(metersPerCentimeter, 1.LengthCentimeters().Meters);
            Assert.Equal(metersPerCentimeter, 1L.LengthCentimeters().Meters);
        }

        [Fact]
        public void LengthMeters()
        {
            // arrange
            var metersPerMeter = 1m;

            // act & assert
            Assert.Equal(metersPerMeter, 1m.LengthMeters().Meters);
            Assert.Equal(metersPerMeter, 1d.LengthMeters().Meters);
            Assert.Equal(metersPerMeter, 1f.LengthMeters().Meters);
            Assert.Equal(metersPerMeter, 1.LengthMeters().Meters);
            Assert.Equal(metersPerMeter, 1L.LengthMeters().Meters);
        }

        [Fact]
        public void LengthKilometers()
        {
            // arrange
            var metersPerKilometer = 1000m;

            // act & assert
            Assert.Equal(metersPerKilometer, 1m.LengthKilometers().Meters);
            Assert.Equal(metersPerKilometer, 1d.LengthKilometers().Meters);
            Assert.Equal(metersPerKilometer, 1f.LengthKilometers().Meters);
            Assert.Equal(metersPerKilometer, 1.LengthKilometers().Meters);
            Assert.Equal(metersPerKilometer, 1L.LengthKilometers().Meters);
        }

        [Fact]
        public void LengthInches()
        {
            // arrange
            var metersPerInch = 0.0254m;

            // act & assert
            Assert.Equal(metersPerInch, 1m.LengthInches().Meters);
            Assert.Equal(metersPerInch, 1d.LengthInches().Meters);
            Assert.Equal(metersPerInch, 1f.LengthInches().Meters);
            Assert.Equal(metersPerInch, 1.LengthInches().Meters);
            Assert.Equal(metersPerInch, 1L.LengthInches().Meters);
        }

        [Fact]
        public void LengthFeet()
        {
            // arrange
            var metersPerFoot = 0.3048m;

            // act & assert
            Assert.Equal(metersPerFoot, 1m.LengthFeet().Meters);
            Assert.Equal(metersPerFoot, 1d.LengthFeet().Meters);
            Assert.Equal(metersPerFoot, 1f.LengthFeet().Meters);
            Assert.Equal(metersPerFoot, 1.LengthFeet().Meters);
            Assert.Equal(metersPerFoot, 1L.LengthFeet().Meters);
        }

        [Fact]
        public void LengthYards()
        {
            // arrange
            var metersPerYard = 0.9144m;

            // act & assert
            Assert.Equal(metersPerYard, 1m.LengthYards().Meters);
            Assert.Equal(metersPerYard, 1d.LengthYards().Meters);
            Assert.Equal(metersPerYard, 1f.LengthYards().Meters);
            Assert.Equal(metersPerYard, 1.LengthYards().Meters);
            Assert.Equal(metersPerYard, 1L.LengthYards().Meters);
        }

        [Fact]
        public void LengthMiles()
        {
            // arrange
            var metersPerMile = 1609.344m;

            // act & assert
            Assert.Equal(metersPerMile, 1m.LengthMiles().Meters);
            Assert.Equal(metersPerMile, 1d.LengthMiles().Meters);
            Assert.Equal(metersPerMile, 1f.LengthMiles().Meters);
            Assert.Equal(metersPerMile, 1.LengthMiles().Meters);
            Assert.Equal(metersPerMile, 1L.LengthMiles().Meters);
        }
    }
}
