using System.Runtime.CompilerServices;

namespace CalculateAreaLibrary
{
    public class Circle : IFigure
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException();

            _radius = radius;
            CalculateArea();
        }

        protected override void CalculateArea()
        {
            _area = Math.PI * Math.Pow(_radius, 2);
        }
    }
}
