using System;

namespace Задача_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи оценку: ");
            string mark = Console.ReadLine();
            switch (mark)
            {
                case "2":
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case "3":
                    Console.WriteLine("Удовлетворительно");
                    break;
                case "4":
                    Console.WriteLine("Хорошо");
                    break;
                case "5":
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Чет не правильно!!");
                    break;
            }
        }
    }
}
