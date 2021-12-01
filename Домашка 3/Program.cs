using System;

namespace Домашка_3
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Ну тут как всегда, выход => 0");
            do
            {
                try
                {
                    Console.Write("m: "); a = GetIn();
                    Console.Write("n: "); b = GetIn();
                    c = 0;
                    for(int i = 1; i <= a; i++)
                    {
                        c += i * b;
                    }
                    Console.WriteLine($"{c}\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ну тут чет не так пошло, теперь по новой)");
                }
            } while (true);
        }
        static int GetIn()
        {
            int a;
            do
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 0)
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        return a;
                    }
                }
                catch (Exception)
                {
                    Console.Write("Эй!! Давай аккуратнее..\n> ");
                }
            } while (true);
        }
    }
}
