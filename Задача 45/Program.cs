using System;

namespace Задача_45
{
    class Program
    {
        static void Main()
        {
            Console.Write("Какой у тебя рост: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write(@"
Теперь выбери свой цвет глаз
  1. Голубой,
  2. Зелёный,
  3. Карий,
  4. Серый.
> ");
            int eyeColor = Convert.ToInt32(Console.ReadLine());
            if (eyeColor == 1 && height <= 140)
            {
                Console.WriteLine("МНЕ ПОДОЙДЁТЕ");
            }
            else
            {
                Console.WriteLine("ДО СВИДАНИЯ");
            }
        }
    }
}
