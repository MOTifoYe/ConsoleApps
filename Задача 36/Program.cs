using System;

namespace Задача_36
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

            if (a <= b && b <= c)
            {
                a = (int)Math.Pow(a, 2);
                b = (int)Math.Pow(b, 2);
                c = (int)Math.Pow(c, 2);
            }
            else if (a > b && b > c)
            {
                if (c > a && c > b)
                {
                    a = c;
                    b = c;
                }
                else if (b > a && b > c)
                {
                    a = b;
                    c = b;
                }
                else if (a > c && a > b)
                {
                    c = a;
                    b = a;
                }

            }
            else
            {
                a *= -1;
                b *= -1;
                c *= -1;
            }

            Console.WriteLine($"a: {a}, b: {b}, c: {c}");






        }
    }
}
