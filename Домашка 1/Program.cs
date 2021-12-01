using System;

namespace Домашка_1
{
	class Program
	{
		static void Main()
		{
			double a, b, c, d, x1, x2;

			Console.WriteLine("a,b,c != 0\nДля выхода 0\n");

			do
			{
				Console.Write("a: "); a = GetIn();
				Console.Write("b: "); b = GetIn();
				Console.Write("c: "); c = GetIn();

				d = Math.Pow(b, 2) - 4 * a * c;
				if (d > 0)
				{
					x1 = -b + Math.Sqrt(d);
					x2 = -b - Math.Sqrt(d);

					Console.WriteLine($"D = {d}, X1 = {x1}, X2 = {x2}");
				}
                else if (d == 0)
                {
					x1 = -b + Math.Sqrt(d);

					Console.WriteLine($"D = {d}, X1 = {x1}");
				}
                else
                {
					Console.WriteLine($"D = {d}\nНу чет не случилось. Будем без иксов)");
                }

				Console.WriteLine();
			} while (true);
		}
		static double GetIn()
        {
			double a;
            do
            {
                try
                {
					a = Convert.ToDouble(Console.ReadLine());
					if (a == 0)
                    {
						System.Environment.Exit(0);
                    }
                    else
                    {
						return a;
                    }
                }
                catch (Exception)
                {
					Console.Write("Эй!! Давай аккуратнее..\n> ");
                }
            } while (true);
        }
	}
}