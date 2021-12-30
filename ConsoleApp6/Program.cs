using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ща распечатаю числа,\nквадрат которых не превышает число");
            Console.Write("введи число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1,c;
            while (true)
            {
                c = b * b;
                if (c < a) Console.WriteLine(b);
                else break;
                
                b++;
            }
            Console.WriteLine("Числа закончились");
        }
    }
}
