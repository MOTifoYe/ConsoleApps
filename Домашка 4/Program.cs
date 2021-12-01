using System;

namespace Домашка_4
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Random random = new Random();

            do
            {
                try
                {
                    Console.WriteLine("У меня есть число от 1 до 30. Угадай..");
                    a = random.Next(1, 30);
                    do
                    {
                        Console.Write("Твой вариант: ");
                        b = GetIn();
                        if (b < a)
                        {
                            Console.WriteLine("Неа, моё число больше");
                        }
                        else if (b>a)
                        {
                            Console.WriteLine("Неа, моё число меньше");
                        }
                        else if (b == a)
                        {
                            Console.WriteLine("Да да да, всё верно");
                            Console.WriteLine("Давай ещё раз");
                            Console.WriteLine();
                            break;
                        }
                    } while (true);
                }
                catch (Exception)
                {
                    Console.WriteLine("Чет не так, го по новой");
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
