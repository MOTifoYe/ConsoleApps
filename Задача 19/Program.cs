using System;

namespace Задача_19
{
    class Program
    {
        static void Main()
        {
            double x, y, z;
            Console.Write("x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Для случая А\n {A(x, y, z)}");
            Console.WriteLine($"Для случая B\n {B(x, y, z)}");
            Console.WriteLine($"Для случая V\n {V(x, y, z)}");
            Console.WriteLine($"Для случая G\n {G(x, y, z)}");
            Console.WriteLine($"Для случая D\n {D(x, y, z)}");
            Console.WriteLine($"Для случая E\n {E(x, y, z)}");
            Console.WriteLine($"Для случая J\n {J(x, y, z)}");

        }

        static string A(double x, double y, double z)
        {
            double a, b;

            a = (Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y))) / (1 + Math.Pow(x, 2) / 2 + Math.Pow(y, 2) / 4);
            b = x * Math.Cos(z) / Math.Sin(z) + Math.Pow(Math.E, -(x + 3));

            return $"a = {a}; b = {b}";
        }
        static string B(double x, double y, double z)
        {
            double a, b;

            a = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(z)));

            b = 1 + Math.Abs(y - x) + Math.Pow(y - x, 2) / 2 + Math.Pow(Math.Abs(y - x), 3) / 3;

            return $"a = {a}; b = {b}";
        }
        static string V(double x, double y, double z)
        {
            double a, b;

            a = (1 + y) * x + y / Math.Pow(x, 2) + 4 / Math.Pow(Math.E, -x - 2) + 1 / Math.Pow(x, 2) + 4;
            b = 1 + Math.Cos(y - 2) / Math.Pow(x, 4) / 2 + Math.Pow(Math.Sin(z), 2);

            return $"a = {a}; b = {b}";
        }
        static string G(double x, double y, double z)
        {
            double a, b;

            a = y + x / (Math.Pow(y, 2) + Math.Abs(Math.Pow(x, 2) / (y + Math.Pow(x, 3) / 3)));
            b = 1 + Math.Pow(Math.Tan(z / 2), 2);

            return $"a = {a}; b = {b}";
        }
        static string D(double x, double y, double z)
        {
            double a, b;

            a = (2 * Math.Cos(x - Math.PI / 6) / (1 / 2 + Math.Pow(Math.Sin(y), 2)));
            b = 1 + Math.Pow(z, 2) / (3 + Math.Pow(z, 2) / 5);

            return $"a = {a}; b = {b}";
        }
        static string E(double x, double y, double z)
        {
            double a, b;

            a = (1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - (2 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))));
            b = Math.Pow(Math.Cos(Math.Cos(1) / Math.Sin(z)), 2);

            return $"a = {a}; b = {b}";
        }
        static string J(double x, double y, double z)
        {
            double a, b;

            a = Math.Log10(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - y / (z + Math.Pow(x, 2) / 4))));
            b = x - Math.Pow(x, 2) / (3 * 2 * 1) + Math.Pow(x, 5) / (5 * 4 * 3 * 2 * 1);

            return $"a = {a}; b = {b}";
        }
    }
}
