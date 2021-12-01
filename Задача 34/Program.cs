using System;

namespace Задача_34
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Введите число 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            c = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
            {
                a = (int)Math.Pow(a, 2);
            }
            if (b >= 0)
            {
                b = (int)Math.Pow(c, 2);
            }
            if (c >= 0)
            {
                c = (int)Math.Pow(c, 2);
            }

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
        }
    }
}
