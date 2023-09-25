namespace Geometry
{
    public class Triangle : IFigure
    {
        double sideA;
        double sideB;
        double sideC;
        public Triangle(double sideA, double sideB, double sideC) 
        { 
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public double CalculateArea()
        {
            if (sideA < 1 || sideB < 1 || sideC < 1)
            {
                return 0;
            }

            double perimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
            return Math.Round(area, 2);
        }

        public static bool IsRightTriangle(double sideA, double sideB, double sideC) 
        {
            var sides = new[] { sideA, sideB, sideC }.OrderBy(side => side).ToList();

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
