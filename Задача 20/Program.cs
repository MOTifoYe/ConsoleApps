using System;

namespace Задача_20
{
    class Program
    {
        static void Main()
        {
            double x;
            Console.Write("X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Число х без дробных цифр {Math.Truncate(x)}");
            Console.WriteLine($"Число х, округлённое до ближайшего целого {Math.Round(x)}");
        }
    }
}
