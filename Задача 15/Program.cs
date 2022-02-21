using System;

namespace Задание_15
{
    class Program
    {
        static void Main()
        {
#pragma warning disable CS0168 // Переменная "s" объявлена, но ни разу не использована.
            double s, a, b, alpha;
#pragma warning restore CS0168 // Переменная "s" объявлена, но ни разу не использована.
            Console.Write("a>b\na: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("alpha(rad): ");
            alpha = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Площадь = {Math.Abs((a + b) * (a - b) / 4 * Math.Sin(alpha) * Math.Cos(alpha))}");
            Console.WriteLine($"Периметр = {a + a + b + b}");

        }
    }
}
