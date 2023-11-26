using FigureAreaCalculator.figures;

namespace AreaCalculatorTests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void CircleRadiusNegative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-35));
        }

        [TestMethod]
        public void TriangleSidesNegative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-35, 12, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(35, -14, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(35, 12, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-35, -12, -10));
        }

        [TestMethod]
        public void CircleSquareCalculate()
        {
            var circle = new Circle(35);

            Assert.AreEqual(3848.4510006474966, circle.CalculateSquare());
        }

        [TestMethod]
        public void TriangleSquareCalculate()
        {
            var triangle = new Triangle(10, 11, 12);

            Assert.AreEqual(51.521233486786784, triangle.CalculateSquare());
        }

        public void IsRightTriangle()
        {
            var triangle = new Triangle(9, 12, 15);

            Assert.AreEqual(true, triangle.IsRightTriangle());
        }

        public void IsNotRightTriangle()
        {
            var triangle = new Triangle(5, 6, 7);

            Assert.AreEqual(false, triangle.IsRightTriangle());
        }
    }
}