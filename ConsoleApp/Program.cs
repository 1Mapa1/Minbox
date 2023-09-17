using GeometryCalculator;




public class Program
{
    private static void Main(string[] args)
    {
        IFigure circle = new Circle(3);
        IFigure rectangle = new Rectangle(3, 4);
        IFigure triangle = new Triangle(3, 4, 5);


        Console.WriteLine($"Площадь круга равняется {circle.CalculateArea()}.");
        Console.WriteLine($"Площадь прямоугольника равняется {rectangle.CalculateArea()}.");
        Console.WriteLine($"Площадь треугольника равняется {triangle.CalculateArea()}.");

        Triangle triangle2 = new Triangle(3, 4, 5);

        if (triangle2.CheckRightTriangle())
        {
            Console.WriteLine("Треугольник прямоугольный.");
        }
        else
        {
            Console.WriteLine("Треугольник не прямоугольный.");
        }
    }
}