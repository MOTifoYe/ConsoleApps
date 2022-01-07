using System;

namespace Задача_51
{
    class Program
    {
        const double FUNTRU = 409.5;
        const double FUNTUK = 453.592;
        const double FUNTOTHER = 500;
        const double GRAMM = 1000;
        static double kilo;
        static int pick;
        static double result;
        static void Main()
        {
            Console.Write("Введи количество КГ: ");
            kilo = Convert.ToDouble(Console.ReadLine());

            Console.Write("1. Россия.\n2. Англия.\n3. Германия, Дания, Исландия.\n   В фунты какой страны перевести? ");
            if (!int.TryParse(Console.ReadLine(), out pick) || (pick < 1 || pick > 3))
            {
                Console.WriteLine("Некорректный ввод! Значение выбрано автоматически (Россия).");
                pick = 1;
            }
            switch (pick)
            {
                case 1:
                    result = kilo / GRAMM / FUNTRU;
                    break;
                case 2:
                    result = kilo / GRAMM / FUNTUK;
                    break;
                case 3:
                    result = kilo / GRAMM / FUNTOTHER;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод!");
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
