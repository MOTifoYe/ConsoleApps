using System;

namespace Задача_21
{
    class Program
    {
        static void Main()
        {
            int dvorX = 50;
            int dvorY = 30;

            int domX = 20;
            int domY = 10;

            int domS = domX * domY;
            int dvorS = dvorX * dvorY - domS;
            int zabor = dvorX * 2 + dvorY * 2 - domX - domY;

            Console.WriteLine($"площадь дома {domS}");
            Console.WriteLine($"площадь двора {dvorS}");
            Console.WriteLine($"длина забора {zabor}");
        }
    }
}