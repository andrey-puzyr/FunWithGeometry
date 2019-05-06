using System;

namespace FunWithGeometry
{
    class Triangle : ITrianleEntity
    {
        const double precision = 0.1E-6;

        readonly double a;
        readonly double b;
        readonly double c;

        public double Area => HeronsFormula(a, b, c);
        public bool IsRightAngled => CalcIsRightAngled(a, b, c);

        public Triangle(double side1, double side2, double side3)
        {
            Guard.Requires(side1 >= 0, "side1 should be positive");
            Guard.Requires(side2 >= 0, "side2 should be positive");
            Guard.Requires(side3 >= 0, "side3 should be positive");
            this.a = side1;
            this.b = side2;
            this.c = side3;
        }

        bool CalcIsRightAngled(double a, double b, double c)
        {
            bool eq1 = IsEq(a * a + b * b, c * c);
            bool eq2 = IsEq(a * a + c * c, b * b);
            bool eq3 = IsEq(b * b + c * c, a * a);
            return eq1 || eq2 || eq3;
        }

        bool IsEq(double x, double y) => Math.Abs(x - y) < precision;

        static double HeronsFormula(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
