using System;

namespace задача_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int rr = Convert.ToInt32(Console.ReadLine());
            if (rr % 13 == 0)
            {
                Console.WriteLine($"Целое число {rr} подходит");

            }

            else
            {
                Console.WriteLine($"Целое число {rr} не подходит");
            }
        }
    }
}
