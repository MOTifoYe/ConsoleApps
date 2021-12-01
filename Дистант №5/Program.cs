using System;

namespace Дистант__5
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Выхода нет . . .");
			do
			{
				try
				{
					Console.Write("Ввод 1 > ");
					double a = Convert.ToDouble(Console.ReadLine());
					Console.Write("Ввод 2 > ");
					double b = Convert.ToDouble(Console.ReadLine());

					Console.WriteLine($"x = {GetX(a, b)}\ny = {GetY(a, b)}");
				}
				catch (Exception)
				{
					Console.WriteLine("\nНе верный ввод\n");
				}
			} while (true);
		}
		static double GetX(double a, double b)
		{
			double x = 0;

			x = (2 / (Math.Pow(a, 2) + 25) + b) / (Math.Sqrt(b) + (a + b) / 2);

			return x;
		}
		static double GetY(double a, double b)
		{
			double y = 0;

			y = (Math.Abs(a) + 2 * Math.Sin(b)) / (5.5 * a);

			return y;
		}
	}
}
