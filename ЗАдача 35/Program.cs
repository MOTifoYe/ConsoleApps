using System;

namespace Задача_35
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введи число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Четное число");
            }
            else
            {
                Console.WriteLine("Не четное число");
            }
        }
    }
}
