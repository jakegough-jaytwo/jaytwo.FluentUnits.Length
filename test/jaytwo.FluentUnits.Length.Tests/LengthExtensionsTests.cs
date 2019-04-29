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

        [Fact]
        public void MultiplyBy()
        {
            // arrange
            var length = Length.FromMeters(2.2);

            // act & assert
            Assert.Equal(1.1m, length.MultiplyBy(0.5m).Meters);
            Assert.Equal(1.1m, length.MultiplyBy(0.5f).Meters);
            Assert.Equal(1.1m, length.MultiplyBy(0.5d).Meters);
            Assert.Equal(4.4m, length.MultiplyBy(2).Meters);
            Assert.Equal(4.4m, length.MultiplyBy(2L).Meters);
        }

        [Fact]
        public void DivideBy()
        {
            // arrange
            var length = Length.FromMeters(2.2);

            // act & assert
            Assert.Equal(4.4m, length.DivideBy(0.5m).Meters);
            Assert.Equal(4.4m, length.DivideBy(0.5f).Meters);
            Assert.Equal(4.4m, length.DivideBy(0.5d).Meters);
            Assert.Equal(1.1m, length.DivideBy(2).Meters);
            Assert.Equal(1.1m, length.DivideBy(2L).Meters);
        }

        [Fact]
        public void Add()
        {
            // arrange
            var length = Length.FromMeters(2.2);
            var lengthToAdd = Length.FromMeters(1.1);

            // act
            var result = length.Add(lengthToAdd);

            // assert
            Assert.Equal(3.3m, result.Meters);
        }

        [Fact]
        public void Subtract()
        {
            // arrange
            var length = Length.FromMeters(3.3);
            var lengthToSubtract = Length.FromMeters(1.1);

            // act
            var result = length.Subtract(lengthToSubtract);

            // assert
            Assert.Equal(2.2m, result.Meters);
        }
    }
}
