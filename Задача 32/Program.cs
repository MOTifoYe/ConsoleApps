using System;

namespace Задача_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;

            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                summa += a;
            }

            Console.WriteLine("Введите число 2");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b > 0)
            {
                summa += b;
            }

            Console.WriteLine("Введите число 3");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c > 0)
            {
                summa += c;
            }

            Console.WriteLine($"Сумма положительных чисел {summa}");

        }
    }
}
