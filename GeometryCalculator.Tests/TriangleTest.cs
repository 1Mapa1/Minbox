using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Tests
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

            IFigure triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var area = triangle.CalculateArea();

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

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var area = triangle.CheckRightTriangle();

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

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var area = triangle.CheckRightTriangle();

            // Assert

            Assert.AreEqual(expected, area);
        }
    }
}
