using System;

namespace Дистант__2
{
	class Program
	{
		static void Main()
		{
			int n;
			string ERR_01 = "\nНе верный ввод\n";

			for (int i =0; i <100; i++)
            {
				Console.WriteLine($"Мне {i} {Qw(i)}");
			}

			Console.WriteLine("Для выхода: 0");

			do
			{
				try
				{
					Console.Write("Ввод ( 1 <= n <= 99 ) > ");
					n = Convert.ToInt32(Console.ReadLine());
					if (n == 0)
                                        {
						break;
                                        }
					if (1 > n||n > 99)
					{
						Console.WriteLine(ERR_01);
						continue;
					}
					Console.WriteLine($"Мне {n} {Qw(n)}");
					Console.WriteLine();
				}
				catch (Exception)
				{
					Console.WriteLine(ERR_01);
				}
			} while (true);
		}
		static string Qw (int a)
		{
			if (a == 11 || a == 12 || a == 13 || a == 14)
            {
				return "лет";
            }
			a %= 10;
			switch (a)
			{
				case 1: return "год";
				case 2:
				case 3:
				case 4: return "года";
				case 0:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9: return "лет";
				default: return "";
			}
		}
	}
}
