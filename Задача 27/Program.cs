using System;

namespace Задача_27
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("введи число");
            int jj = Convert.ToInt32(Console.ReadLine());

            if (jj <= 5 && jj >= 0)
            {
                Console.WriteLine($"Число {jj} подходит");
            }
            else
            {
                Console.WriteLine($"Число {jj} не подходит");
            }
        }
    }
}
