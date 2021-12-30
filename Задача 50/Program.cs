using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string[] fraz1 = new string[] 
            {
                "Я калькулятор Женя,\nпосчитай во мне полностью",
                "Приветствую, мой господин",
                "Я заждалась тебя, братик",
                "Ты вспомнил обо мне, проведем еще одну ночь вместе?",
                "Спс за ночку, дорогая", 
                "Потрогай еще циферки, мне это очень нравится",
                "Без тебя так одиноко...",
                "Яматекудасай",
                "Я ваша горничная,господин",
                "Не уходи от меня больше",
                "А ты вырос за это время",
                "Не оставляй...меня...одну",
                "Спасибо за заботу",
                "Пока тебе не исполнится 18,\nникаких материалов для взрослых"
            };

            Console.WriteLine(fraz1[rnd.Next(fraz1.Length)]);
            Console.Write("Ода, введи число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Мм, еще, введи второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Как мне сделать, приятно? (-+/*): ");
            string c = Console.ReadLine();
            switch (c)
            {
                case "+": Console.WriteLine(a + b);
                    break;
                case "-": Console.WriteLine(a - b);
                    break;
                case "*": Console.WriteLine(a * b);
                    break;
                case "/": Console.WriteLine((double)a / (double)b);
                    break;
                default: 
                    break; 
            }
            Console.WriteLine("Я буду тебя ждать снова");
        }
    }
}
