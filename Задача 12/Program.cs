using System;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double R = 45;
            double C = 2 * pi * R;
            double A = pi * Math.Pow(R, 2);

            Console.WriteLine(C);
            Console.WriteLine(A);

        }
    }
}
