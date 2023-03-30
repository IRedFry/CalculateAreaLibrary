using System.Runtime.CompilerServices;

namespace CalculateAreaLibrary
{
    // Класс круга
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double radius)
        {
            // Круга с радиусом меньшим или равным нулю быть не может
            if (radius <= 0)
                throw new ArgumentOutOfRangeException();

            _radius = radius;
            CalculateArea();
        }
        // Расчет площади круга по формуле r^2 * pi
        protected override void CalculateArea()
        {
            _area = Math.PI * Math.Pow(_radius, 2);
        }
    }
}
