using System;

namespace Задача_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи число а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введи число b: ");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
