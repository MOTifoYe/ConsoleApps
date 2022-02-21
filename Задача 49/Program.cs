using System;

namespace Задача_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 - выход");
            while (true)
            {
                Console.Write("Введи букву: ");
                string a = Console.ReadLine();
                if (a == "0")
                {
                    break;
                }
                switch (a)
                {
                    case "а":
                        Console.WriteLine("гласный");
                        break;
                    case "б":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "в":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "г":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "д":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "е":
                        Console.WriteLine("гласный");
                        break;
                    case "ё":
                        Console.WriteLine("гласный");
                        break;
                    case "ж":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "з":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "и":
                        Console.WriteLine("гласный");
                        break;
                    case "и́":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "к":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "л":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "м":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "н":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "о":
                        Console.WriteLine("гласный");
                        break;
                    case "п":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "р":
                        Console.WriteLine("согласный,звонкий");
                        break;
                    case "с":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "т":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "у":
                        Console.WriteLine("гласный");
                        break;
                    case "ф":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "х":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "ц":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "ч":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "ш":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "щ":
                        Console.WriteLine("согласный,глухой");
                        break;
                    case "ы":
                        Console.WriteLine("гласный");
                        break;
                    case "ъ":
                        Console.WriteLine("-");
                        break;
                    case "ь":
                        Console.WriteLine("-");
                        break;
                    case "э":
                        Console.WriteLine("гласный");
                        break;
                    case "ю":
                        Console.WriteLine("гласный");
                        break;
                    case "я":
                        Console.WriteLine("гласный");
                        break;

                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }
    }
}
