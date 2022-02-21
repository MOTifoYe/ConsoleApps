using System;

namespace Задача_18
{
    class Program
    {
        static void Main()
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
