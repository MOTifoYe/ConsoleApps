using System;

namespace Дистант__4
{
	class Program
	{
		static void Main()
		{
			int n = 0;
			int i = 500;
			do
			{
				if (i % 13 == 0)
				{
					n++;
					Console.WriteLine($"{i} % 13");
				}
				else if (i % 17 == 0)
				{
					n++;
					Console.WriteLine($"{i} % 17");
				}
				i++;
			} while (20 > n);
			Console.WriteLine($"{n}");

		}
	}
}
