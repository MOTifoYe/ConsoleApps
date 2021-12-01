using System;

namespace Задача_44
{
    class Program
    {
        static void Main()
        {
            int head = 0, years;

            Console.Write("Сколько лет дракону: ");
            years = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<=years; i++)
            {
                if (i < 100)
                {
                    head += 3;
                }
                else
                {
                    head += 2;
                }
            }

            Console.WriteLine($"У дракона {head} голов и {head * 2} глаз.");
        }
    }
}
