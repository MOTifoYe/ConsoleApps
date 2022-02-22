using System;

namespace Задача_51
{
    class Program
    {
        const double POUNDRU = 0.45359237;
        const double POUNDUK = 0.40951241;
        const double POUNDFR = 0.489505;
        static double pound;
        static int pick;
        static double result;

        static void Main()
        {
            Console.Write("Введи количество фунтов: ");
            pound = Convert.ToDouble(Console.ReadLine());

            Console.Write("1. Россия.\n2. Англия.\n3. Франция.\n\tВ фунты какой страны использовать? ");
            if (!int.TryParse(Console.ReadLine(), out pick) || (pick < 1 || pick > 3))
            {
                Console.WriteLine("Некорректный ввод! Значение выбрано автоматически (Россия).");
                pick = 1;
            }
            switch (pick)
            {
                case 1:
                    result = pound * POUNDRU;
                    break;
                case 2:
                    result = pound * POUNDUK;
                    break;
                case 3:
                    result = pound * POUNDFR;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод!");
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
