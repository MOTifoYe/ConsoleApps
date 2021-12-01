using System;

namespace Домашка_5
{
    class Program
    {
        static void Main()
        {
            double[] a = new double[5];
            Console.WriteLine("У меня тут массив из пяти элементов, заролни его");
            Console.WriteLine("Тут тоже нуль для выхода");
            do
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"{i+1}: ");
                        a[i] = GetIn();
                        if (a[i]<0)
                        {
                            a[i] = Math.Abs(a[i]);
                        }
                        if ( (i+1) % 2 != 0 )
                        {
                            a[i] = Math.Pow(a[i],2);
                        }
                    }
                    Console.WriteLine($"[{a[0]}, {a[1]}, {a[2]}, {a[3]}, {a[4]}]\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ай.. Косяк!");
                }
            } while (true);
        }
        static double GetIn()
        {
            double a;
            do
            {
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
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
