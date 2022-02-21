using System;

namespace Задача_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            Console.Write("Введи число а: ");
            a[0] = int.Parse(Console.ReadLine());
            Console.Write("Введи число b: ");
            a[1] = int.Parse(Console.ReadLine());
            Console.Write("Введи число с: ");
            a[2] = int.Parse(Console.ReadLine());

            Array.Sort(a);
            Array.Reverse(a);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
