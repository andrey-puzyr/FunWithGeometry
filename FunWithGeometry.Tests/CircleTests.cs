using System;
using Xunit;

namespace FunWithGeometry.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, Math.PI)]
        [InlineData(2, 4 * Math.PI)]
        public void AreaIsExpected(double radius, double expectedArea) =>
            Assert.Equal(expectedArea, Geometry.CreateCircle(radius).Area);

        [Fact]
        public void InvalidArgs() =>
            Assert.Throws<ArgumentException>(() => Geometry.CreateCircle(-1).Area);
    }
}
