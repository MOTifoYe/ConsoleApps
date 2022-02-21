using System;

namespace Задача_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи число а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введи число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введи число с: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(a, b), c));
        }
    }
}
