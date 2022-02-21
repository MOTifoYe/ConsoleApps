using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 9;
            double c = Math.Sqrt(Math.Pow(a, 2) + b * b);
            double s = a * b / 2;

            Console.WriteLine(c);
            Console.WriteLine(s);
        }
    }
}
