using System;

namespace ЗАдача_33
{
    class Program
    {
        static void Main()
        {
            int a, b, c, sum = 0;
            Console.WriteLine("Введите число 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            c = Convert.ToInt32(Console.ReadLine());
        
            if (a == 0)
            {
                sum += 1;
            }
            if (b == 0)
            {
                sum += 1;
            }
            if (c == 0)
            {
                sum += 1;
            }

            Console.WriteLine($"Из этих чисел {sum} равны нулю");

        }
    }
}
