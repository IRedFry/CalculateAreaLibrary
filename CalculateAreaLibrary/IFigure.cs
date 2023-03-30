
namespace CalculateAreaLibrary
{
    public abstract class IFigure
    {
        protected double _area;
        public double GetArea() { return _area; }
        protected abstract void CalculateArea();
    }
}
