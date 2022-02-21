using System;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 7;
            double r;
            double rr;
            double h;
            double s;

            r = Math.Sqrt(3) * a / 6;
            rr = 2 * r;
            h = 3 * r;
            s = a * h / 2;

            Console.WriteLine($"Радиус вписанной окружности: {r}");
            Console.WriteLine($"Радиус описанной окружности {rr}");
            Console.WriteLine($"Высота треугольника {h}");
            Console.WriteLine($"Площадь треугольника {s}");

        }
    }
}
