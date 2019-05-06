using System;

namespace FunWithGeometry
{
    class Circle : ICircleFigure
    {
        readonly double radius;

        public double Area => radius * radius * Math.PI;

        public Circle(double radius)
        {
            Guard.Requires(radius >= 0, "radius should be positive");
            this.radius = radius;
        }
    }
}
