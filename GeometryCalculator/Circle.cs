namespace GeometryCalculator
{
    public class Circle : IFigure
    {
        double radius;
        public Circle(double radius) 
        { 
            this.radius = radius;
        }
        public double CalculateArea()
        {
            if (radius < 1)
            {
                return 0;
            }
            double area = Math.PI * radius * radius;
            return Math.Round(area, 2);
        }
    }
}