using System;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 6;
            double y = 10;
            double ll = (Math.Abs(x) - Math.Abs(y)) / (1 + Math.Abs(x * y));
            Console.WriteLine(ll);

        }
    }
}
