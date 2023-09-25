namespace Geometry.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalculateArea_IsInput5and4and3_Return6()
        {
            // Arrange
            double sideA = 5;
            double sideB = 4;
            double sideC = 3;
            double expected = 6;

            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var area = GeometryCalc.CalculateArea(triangle);

            // Assert

            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void CheckRightTriangle_IsInput5and4and3_ReturnTrue()
        {
            // Arrange
            double sideA = 5;
            double sideB = 4;
            double sideC = 3;
            bool expected = true;

            // Act
            var area = Triangle.IsRightTriangle(sideA, sideB, sideC);

            // Assert

            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void CheckRightTriangle_IsInput5and4and3_ReturnFalse()
        {
            // Arrange
            double sideA = 5;
            double sideB = 5;
            double sideC = 3;
            bool expected = false;

            var area = Triangle.IsRightTriangle(sideA, sideB, sideC);

            // Assert

            Assert.AreEqual(expected, area);
        }
    }
}
