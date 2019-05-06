namespace FunWithGeometry
{
    public static class Geometry
    {
        public static ICircleEntity CreateCircle(double radius) => new Circle(radius);
        public static ITrianleEntity CreateTriangle(double side1, double side2, double side3) => new Triangle(side1, side2, side3);
    }
}
