﻿using System;

namespace Задача_16
{
    class Program
    {
        static void Main()
        {
            double x1, x2, y1, y2;
            Console.Write("x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"расстояние между точками: {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}");
        }
    }
}
