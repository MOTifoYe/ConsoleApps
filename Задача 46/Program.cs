using System;

namespace Задача_46
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ведите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Не бей по своим..");
            }
            else if (a >= 0 && a < 28)
            {
                Console.WriteLine("Недолёт");
            }
            else if (a >= 28 && a < 30)
            {
                Console.WriteLine("Попал");
            }
            else if (a >= 30)
            {
                Console.WriteLine("Перелёт");
            }
        }
    }
}
