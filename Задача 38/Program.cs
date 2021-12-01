using System;

namespace Задача_38
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

            if (a == b && b == c) Console.WriteLine("равносторонний");
            else
            {
                if (a == b || b == c || a == c) Console.WriteLine("равнобедренный");
                else Console.WriteLine("Разносторонний");
            }
        }
    }
}
