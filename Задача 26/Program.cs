using System;

namespace Задача_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи Х: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Это абсолютное значение Х: {Math.Abs(x)}");
        }
    }
}
