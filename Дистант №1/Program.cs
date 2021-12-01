using System;

namespace Дистант__1
{
	class Program
	{
		static void Main()
		{
			int a;
			do
			{
				try
				{
					Console.Write("Ввод ( для выхода 0 ) >  ");
					a = Convert.ToInt32(Console.ReadLine());

					if (a == 0)
					{
						break;
					}
					if (a % 10 == 7)
					{
						Console.WriteLine($"Число {a} оканчивается 7 и не является четным.");
					}
					else if (a % 2 == 0)
					{
						Console.WriteLine($"Число {a} является четным.");

					}
					else
					{
						Console.WriteLine($"Число {a} не является четным.");
					}

					Console.WriteLine();
				}
				catch (Exception)
				{
					Console.WriteLine("\nНе верный ввод\n");
				}
			} while (true);
		}
	}
}
