namespace FunWithGeometry
{
    public interface IFigure
    {
        double Area { get; }
    }
    public interface ICircleFigure : IFigure { }
    public interface ITriangleFigure : IFigure
    {
        bool IsRightAngled { get; }
    }
}
