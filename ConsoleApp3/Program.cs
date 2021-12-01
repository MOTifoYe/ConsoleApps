using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите возраст");
            int q = Convert.ToInt32(Console.ReadLine());

            if (q<1 || q > 99)
            {
                Console.WriteLine("не правильный возраст");
            }

            if (q >= 11 & q <= 14)
            {
                Console.WriteLine($"Мне {q} лет");
            }
            else if (q % 10 == 1)
            {
                Console.WriteLine($"Мне {q} год");
            }
            else if (q % 10 == 2 | q % 10 == 3 | q % 10 == 4)
            {
                Console.WriteLine($"Мне {q} года");
            }
            else if (q % 10 == 0 | q % 10 == 5 | q % 10 == 6 | q % 10 == 7 | q % 10 == 8 | q % 10 == 9)
            {
                Console.WriteLine($"Мне {q} лет");
            }
        }
    }
}
