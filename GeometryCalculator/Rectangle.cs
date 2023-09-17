using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public class Rectangle : IFigure
    {
        double sideA;
        double sideB;
        public Rectangle(double sideA, double sideB) 
        { 
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public double CalculateArea()
        {
            if (sideA < 1 || sideB < 1)
            {
                return 0;
            }

            return sideA * sideB;
        }
    }
}
