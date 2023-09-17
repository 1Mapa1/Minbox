using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Tests
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void CalculateArea_IsInput2and4_Return8()
        {
            // Arrange
            double sideA = 2;
            double sideB = 4;
            double expected = 8;

            IFigure rectangle = new Rectangle(sideA, sideB);

            // Act
            var area = rectangle.CalculateArea();

            // Assert

            Assert.AreEqual(expected, area);
        }
        [TestMethod]
        public void CalculateArea_IsInput10and4_Return40()
        {
            // Arrange
            double sideA = 10;
            double sideB = 4;
            double expected = 40;

            IFigure rectangle = new Rectangle(sideA, sideB);

            // Act
            var area = rectangle.CalculateArea();

            // Assert

            Assert.AreEqual(expected, area);
        }
    }
}
