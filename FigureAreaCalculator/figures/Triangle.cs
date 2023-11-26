using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureAreaCalculator.interfaces;

namespace FigureAreaCalculator.figures
{
    public class Triangle : IFigure
    {
        int _firstSide, _secondSide, _thirdSide;
        double _perimeter, _square, _semiperimeter;

        public Triangle(int firstSide, int secondSide, int thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной.");

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public double CalculateSquare()
        {
            _perimeter = _firstSide + _secondSide + _thirdSide;
            _semiperimeter = _perimeter / 2;

            double firstSideCoef = _semiperimeter - _firstSide;
            double secondSideCoef = _semiperimeter - _secondSide;
            double thirdSideCoef = _semiperimeter - _thirdSide;

            _square = Math.Sqrt(_semiperimeter * firstSideCoef * secondSideCoef * thirdSideCoef);
            return _square;
        }

        public bool IsRightTriangle()
        {
            int[] sides = { _firstSide, _secondSide, _thirdSide };
            sides = sides.Order().ToArray();
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) ? true : false;
        }
    }
}
