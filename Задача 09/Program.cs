using System;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 34;
            double b = -23;

            double r1 = (a * a + b * b) / 2;
            double r2 = (Math.Abs(a) + Math.Abs(b)) / 2;

            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
}
