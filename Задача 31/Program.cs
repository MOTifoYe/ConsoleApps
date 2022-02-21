using System;

namespace Задача_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int ee = Convert.ToInt32(Console.ReadLine());

            int a, b, c;

            c = ee % 10;
            ee /= 10;

            b = ee % 10;
            ee /= 10;

            a = ee % 10;



            if (c > b && c > a)
            {
                Console.WriteLine($"Наибольшая цифра {c} ");

            }
            else if (b > c && b > a)
            {
                Console.WriteLine($"Наибольшая цифра {b} ");

            }
            else if (a > b && a > c)
            {
                Console.WriteLine($"Наибольшая цифра {a} ");

            }
            else
            {
                Console.WriteLine($" {a} ");

            }



        }
    }
}
