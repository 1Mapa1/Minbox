

namespace GeometryCalculator.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea_IsInput1_Return3point14()
        {
            // Arrange
            double radius = 1;
            double expected = 3.14;

            IFigure circle = new Circle(radius);

            // Act
            var area = circle.CalculateArea();

            // Assert

            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void CalculateArea_IsInput10_Return314point16()
        {
            // Arrange
            double radius = 10;
            double expected = 314.16;

            IFigure circle = new Circle(radius);

            // Act
            var area = circle.CalculateArea();

            // Assert

            Assert.AreEqual(expected, area);
        }

    }
}