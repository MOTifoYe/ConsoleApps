using System;

namespace Задача_17
{
    class Program
    {
        static void Main()
        {
            double x1, x2, x3, y1, y2, y3, a, b, c, p;
            Console.Write("x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3: ");
            y3 = Convert.ToDouble(Console.ReadLine());

            a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            b = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

            p = a + b + c;
            Console.WriteLine($"периметр: {p}");
            p /= 2;
            Console.WriteLine($"площадь: {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");



        }
    }
}
