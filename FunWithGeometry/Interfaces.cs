namespace FunWithGeometry
{
    public interface IFigure
    {
        double Area { get; }
    }
    public interface ICircleEntity : IFigure { }
    public interface ITrianleEntity : IFigure
    {
        bool IsRightAngled { get; }
    }
}
