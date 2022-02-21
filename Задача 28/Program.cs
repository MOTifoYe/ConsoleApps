using System;

namespace Задача_28
{
    class Program
    {
        static void Main()
        {
            // 1000 - 1000*0,1

            Console.WriteLine("Введите сумму покупки");
            double hh = Convert.ToDouble(Console.ReadLine());
            if (hh >= 10000)
            {
                Console.WriteLine($"Сумма покупки включает скидку 10% {hh - hh * 0.1} ");

            }

            else
            {
                Console.WriteLine($"Сумма покупки не включает скидку 10% {hh} ");

            }



        }
    }
}
