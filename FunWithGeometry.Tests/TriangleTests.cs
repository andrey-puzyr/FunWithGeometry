using System;
using Xunit;

namespace FunWithGeometry.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 1, 1.414213562, 1 / 2d)]
        [InlineData(2, 4, 4.472135955, 2 * 4 / 2d)]
        public void AreaIsExpected(double s1, double s2, double s3, double expectedArea) =>
        Assert.Equal(expectedArea, Math.Round(Geometry.CreateTriangle(s1, s2, s3).Area, 9));

        [Theory]
        [InlineData(1, 1, 1.414213562, true)]
        [InlineData(2, 3, 7, false)]
        public void IsRight(double s1, double s2, double s3, bool isRight) =>
            Assert.Equal(isRight, Geometry.CreateTriangle(s1, s2, s3).IsRightAngled);

        [Theory]
        [InlineData(-1, 0, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(0, 0, -1)]
        public void InvalidArgs(double s1, double s2, double s3) =>
            Assert.Throws<ArgumentException>(() => Geometry.CreateTriangle(s1, s2, s3));
    }
}
