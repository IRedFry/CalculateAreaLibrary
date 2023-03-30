
namespace CalculateAreaLibrary
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;
        private bool IsRight;

        public Triangle(double a, double b, double c)
        {
            if (a > b + c || b > a + c || c > a + b)
                throw new Exception("One of sides is bigger then sum of others");

            _a = a;
            _b = b;
            _c = c;

            SortSides();
            CheckIsRight();
            CalculateArea();
        }

        protected override void CalculateArea()
        {
            if (IsRight)
                CalculateAreaOfRightTriangle();
            else
                CalculareAreaOfNotRightTriangle();
        }

        private void CalculateAreaOfRightTriangle()
        {
            _area = _b * _c / 2;
        }

        private void CalculareAreaOfNotRightTriangle()
        {
            double p = (_a + _b + _c) / 2;
            _area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        private void CheckIsRight()
        {
            if (Math.Pow(_a, 2) == Math.Pow(_b, 2) + Math.Pow(_c, 2))
                IsRight = true;
            else
                IsRight = false;
        }

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
