using FigureAreaCalculator.interfaces;

namespace FigureAreaCalculator.figures
{
    public class Circle : IFigure
    {
        double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным.");

            _radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

    }
}