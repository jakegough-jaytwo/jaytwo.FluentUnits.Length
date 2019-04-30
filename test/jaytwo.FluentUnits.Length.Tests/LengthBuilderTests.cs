using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace jaytwo.FluentUnits.Tests
{
    public class LengthBuilderTests
    {
        [Fact]
        public void AsLength_integer()
        {
            // arrange
            var intValue = 1;

            // act
            var length = intValue.AsLength().Meters();

            // assert
            Assert.Equal(1m, length.Meters);
        }

        [Fact]
        public void AsLength_long()
        {
            // arrange
            var longValue = 1L;

            // act
            var length = longValue.AsLength().Meters();

            // assert
            Assert.Equal(1m, length.Meters);
        }

        [Fact]
        public void AsLength_decimal()
        {
            // arrange
            var decimalValue = 1m;

            // act
            var length = decimalValue.AsLength().Meters();

            // assert
            Assert.Equal(1m, length.Meters);
        }

        [Fact]
        public void AsLength_double()
        {
            // arrange
            var doubleValue = 1d;

            // act
            var length = doubleValue.AsLength().Meters();

            // assert
            Assert.Equal(1m, length.Meters);
        }

        [Fact]
        public void AsLength_float()
        {
            // arrange
            var floatValue = 1f;

            // act
            var length = floatValue.AsLength().Meters();

            // assert
            Assert.Equal(1m, length.Meters);
        }
    }
}
