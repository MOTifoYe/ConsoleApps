using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_48
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";

            Console.Write("Сколько тебе лет, определим тебя в отряд: ");
            a = Console.ReadLine();
            
            switch (a)
            {
                case "6": Console.WriteLine("У тебя 5 отряд!");
                    break;
                case "7": Console.WriteLine("У тебя 5 отряд!");
                    break;
                case "8": Console.WriteLine("У тебя 4 отряд!");
                    break;
                case "9": Console.WriteLine("У тебя 4 отряд!");
                    break;
                case "10": Console.WriteLine("У тебя 3 отряд!");
                    break;
                case "11": Console.WriteLine("У тебя 3 отряд!");
                    break;
                case "12": Console.WriteLine("У тебя 2 отряд!");
                    break;
                case "13": Console.WriteLine("У тебя 2 отряд!");
                    break;
                case "14": Console.WriteLine("У тебя 1 отряд!");
                    break;
                case "15": Console.WriteLine("У тебя 1 отряд!");
                    break;
                default: Console.WriteLine("Ты не подходишь по возрасту");
                    break;
            }
        }
    }
}
