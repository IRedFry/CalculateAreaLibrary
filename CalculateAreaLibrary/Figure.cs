
namespace CalculateAreaLibrary
{
    // Абстрактный класс, от которого будут наследоваться все фигуры
    public abstract class Figure
    {
        // Поле, содержащее значение площади
        protected double _area;
        // Метод, возращаюсь площадь
        public double GetArea() { return _area; }
        // Метод расчета площади
        protected abstract void CalculateArea();
    }
}
