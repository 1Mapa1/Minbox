using Geometry;

namespace ConsoleApp
{
    public class GeometryCalculator
    {
        private static List<string> figurs = new List<string>()
        {
            "треугольник",
            "круг"
        };

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Калькулятор фигур \n");

                Console.WriteLine("Выберите фигуру (введите цифру): ");

                for (int i = 0; i < figurs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {figurs[i]}");
                }

                Console.Write("Ввод: ");
                var answer = GetAnswer(false, new[] { "1", "2" });

                if (answer == "1")
                {
                    StartTriangle();
                }
                else if (answer == "2")
                {
                    StartCircle();
                }

                Console.WriteLine("Хотите выйти из приложения? (ввудите цифру)");

                Console.WriteLine("1. Да");
                Console.WriteLine("2. Нет");

                Console.Write("Ввод: ");

                answer = GetAnswer(false, new[] { "1", "2" });

                if (answer == "1")
                {
                    break;
                }  
                else
                {
                    Console.Clear();
                }
            }
        }

        private static void StartTriangle()
        {
            Console.Clear();
            Console.WriteLine("Треугольник (введите цифру)");

            Console.WriteLine("1. Площадь");
            Console.WriteLine("2. Правильность треугольника");

            Console.Write("Ввод: ");

            var answer = GetAnswer(false, new[] { "1", "2" });

            var sides = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Введите {i + 1} сторону: ");
                sides.Add(Convert.ToDouble(GetAnswer(true)));
            }


            if (answer == "1")
            {
                var figure = new Triangle(sides[0], sides[1], sides[2]);
                Console.WriteLine($"Площадь треугольника равняется {GeometryCalc.CalculateArea(figure)}.");
            }
            else if (answer == "2")
            {
                if (Triangle.IsRightTriangle(sides[0], sides[1], sides[2]))
                {
                    Console.WriteLine($"Треугольник является прямоугольным.");
                }
                else
                {
                    Console.WriteLine($"Треугольник не является прямоугольным.");
                }
            }
        }

        private static void StartCircle()
        {
            Console.Clear();
            Console.WriteLine("Расчет площади круга по радиусу \n");

            Console.Write("Введите радиус: ");
            var radius = Convert.ToDouble(GetAnswer(true));

            var figure = new Circle(radius);
            Console.WriteLine($"Площадь круга равняется {GeometryCalc.CalculateArea(figure)}.");
        }
        private static string GetAnswer(bool isInt, params string[] rightAnswers)
        {
            var answer = Console.ReadLine().ToLower();
            while (true)
            {
                if (isInt)
                {
                    answer = answer.Replace('.', ',');
                    if (double.TryParse(answer, out _))
                    {
                        return answer;
                    }
                }
                else
                {
                    foreach (var rightAnswer in rightAnswers)
                    {
                        if (rightAnswer == answer)
                        {
                            return answer;
                        }
                    }
                }

                Console.WriteLine("Вы ввели некорректный ответ");
                Console.Write("Ввод: ");
                answer = Console.ReadLine().ToLower();
            }
        }
    }
}
