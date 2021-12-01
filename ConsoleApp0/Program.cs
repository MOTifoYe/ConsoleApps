using System;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Перечисление аргументов для Main()
			foreach (string value in args)
			{
				Console.WriteLine(value);
			}
			Console.WriteLine("END ARGS . . .");

			// Создание массивов
			int[] numbers = { 4, 6, 2, 3 };
			int[] numbers2 = { 1, 2, 3 };
			int[,] testArray = new int[2, 4];

			// У строк есть собственные методы и переменные,
			// правильно называть это свойствами,
			// которые позволяют узнать информацию о строке 
			string myString = "Hello, world!";
			Console.WriteLine("Lenght 'myString': " + myString.Length);

			// Метод substring возващает часть строки и принимает значение индекса и длинны
			Console.WriteLine("substring может принимать один аргумент".Substring(10));
			Console.WriteLine("или может принимать два аргумента".Substring(20, 3));

			// Так же можно использовать диапазон [..], [a..], [..b], [a..^b]
			string strangeSymbols = "© 2014 Σγμβόλσ";
			Console.WriteLine(strangeSymbols[3..^3]);

			// Тип string может иметь особое значение - null.
			// Это не пустая строка, а отсутствие всякой строки.
			// Интересно, что тип int такого значения иметь не может.
			myString = null;

			int number = int.Parse("42"); // Из строки в число
			string numString = 42.ToString(); // Из числа в строку

			// Точка или запятая, зависит от настроек операционной системы
			double number2 = double.Parse("34.42", CultureInfo.InvariantCulture);

			// Следующий вызов не зависит от настроек и всегда ожидает точку в качестве разделителя
			number2 = double.Parse("34.42", CultureInfo.InvariantCulture);

			// Следующий вызов не зависит от настроек и всегда использует точку в качестве разделителя
			string invariantNumber2 = number2.ToString(CultureInfo.InvariantCulture);
			Console.WriteLine(invariantNumber2); //34.42

			Console.WriteLine(GetGreetingMessage("Student", 10.01));
			Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
			Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));

			Console.WriteLine(NbaExtrap(12, 20));
			Console.WriteLine(NbaExtrap(10, 10));
			Console.WriteLine(NbaExtrap(5, 17));
			Console.WriteLine(NbaExtrap(0, 0));

			Console.WriteLine(Math.Min(1, 1));

			Console.WriteLine(GetMinX(1, 2, 3));
			Console.WriteLine(GetMinX(1, -2, -3));
			Console.WriteLine(GetMinX(5, 4.5, 1));
			Console.WriteLine(GetMinX(5, 4.4, 1));

			Console.WriteLine("IndexOf - start");
			foreach (var value in numbers2)
			{
				Console.WriteLine(Array.IndexOf(numbers, value));
			}
			Console.WriteLine("IndexOf - end");
			int[] qwer = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			Array.Resize(ref qwer, 3);
            foreach (var i in qwer)
			{
				Console.Write(i + " ");
			}

		}

		/// <summary>
		/// Возвращает приветствующую строку 
		/// с именем и заработной платой сотрудника,
		/// округленной до ближайшего значения вверх.
		/// </summary>
		/// <param name="name">Имя сотрудника</param>
		/// <param name="salary">Заработная плата</param>
		/// <returns></returns>
		public static string GetGreetingMessage(string name, double salary)
		{
			return String.Format($"Hello, {name}, your salary is {Math.Ceiling(salary)}");
		}

		/// <summary>
		/// Возвращает прямую экстраполяцию ppg за время time 
		/// с округлением до ближайшей десятой. 
		/// Вернуть 0, если 0.
		/// </summary>
		/// <param name="ppg">очки за игру</param>
		/// <param name="mpg">минуты за игру</param>
		/// <param name="time">По умолчанию 48</param>
		/// <returns></returns>
		public static double NbaExtrap(double ppg, double mpg, double time = 48)
		{
			return ppg == 0 ? 0 : Math.Round(time / mpg * ppg, 1);
		}

		/// <summary>
		/// Возвращает минимум для функции (квадратное уравнение) с заданными аргументами
		/// </summary>
		/// <returns></returns>
		private static string GetMinX(double a, double b, double c)
		{
			return (a <= 0 && b != 0) ? "Impossible" : $"{-b / (2 * a)}";
		}
	}
}
