namespace FunWithGeometry
{
    public static class Geometry
    {
        public static ICircleFigure CreateCircle(double radius) => new Circle(radius);
        public static ITriangleFigure CreateTriangle(double side1, double side2, double side3) => new Triangle(side1, side2, side3);
    }
}
