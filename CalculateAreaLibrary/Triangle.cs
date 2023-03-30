
namespace CalculateAreaLibrary
{
    // Класс треугольника
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;
        private bool IsRight;

        public Triangle(double a, double b, double c)
        {
            // Проверка на существование треугольника
            if (a > b + c || b > a + c || c > a + b)
                throw new Exception("One of sides is bigger then sum of others");

            _a = a;
            _b = b;
            _c = c;

            SortSides();
            CheckIsRight();
            CalculateArea();
        }
        // Расчет площади в зависимости от типа треугольника
        protected override void CalculateArea()
        {
            if (IsRight)
                CalculateAreaOfRightTriangle();
            else
                CalculareAreaOfNotRightTriangle();
        }
        // Расчет площади прямоугольного треугольника
        private void CalculateAreaOfRightTriangle()
        {
            _area = _b * _c / 2;
        }
        // Расчет площади треугольника через три стороны
        private void CalculareAreaOfNotRightTriangle()
        {
            double p = (_a + _b + _c) / 2;
            _area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
        // Проверка на прямоугольный треугольник
        private void CheckIsRight()
        {
            if (Math.Pow(_a, 2) == Math.Pow(_b, 2) + Math.Pow(_c, 2))
                IsRight = true;
            else
                IsRight = false;
        }
        // Сортировка сторон по убыванию
        // Чтобы при проверке на прямоугольный треугольник гипотенуза всегда была в переменной _a
        private void SortSides()
        {
            if (_b > _a)
            {
                double temp = _a;
                _a = _b;
                _b = temp;
            }
            if (_c > _b)
            {
                double temp = _b;
                _b = _c;
                _c = temp;
            }
            if (_b > _a)
            {
                double temp = _a;
                _a = _b;
                _b = temp;
            }
        }
    }
}
