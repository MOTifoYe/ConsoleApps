using System;

namespace ЗАдача_37
{
    class Program
    {
        static void Main()
        {
            int a, b, c, mul = 0;
            Console.WriteLine("Введите число 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            c = Convert.ToInt32(Console.ReadLine());

            if (c > a && c > b)
            {
                if (b > a)
                {
                    mul = c * b;
                }
                else
                {
                    mul = c * a;
                }
            }
            else if (b > a && b > c)
            {
                if (c > a)
                {
                    mul = b * c;
                }
                else
                {
                    mul = b * a;
                }
            }
            else if (a > c && a > b)
            {
                if (c > b)
                {
                    mul = a * c;
                }
                else
                {
                    mul = b * a;
                }
            }
            Console.WriteLine($"mul {mul}");
        }
    }
}
