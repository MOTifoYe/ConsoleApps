using System;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = 60.3;
            double v2 = 84.8;

            double s = 13.24;

            double t = 1.2;
            Console.WriteLine($"Скорость первого автомобиля {v1} км/ч,");
            Console.WriteLine($"второго — {v2} км/ч,");
            Console.WriteLine($"расстояние между ними {s} км.");

            double s1 = v1 * t;
            double s2 = v2 * t;
            s += s1 + s2;

            Console.WriteLine($"Расстояние между ними через {t} часов, ");
            Console.WriteLine($"если автомобили удаляются друг от друга,");
            Console.WriteLine($"будет {s} км.");
        }
    }
}
