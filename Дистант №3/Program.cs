using System;

namespace Дистант__3
{
	class Program
	{
		static void Main()
		{
			int n = 0;
			for (int i = 1000; i < 10000; i++)
			{
				if ( i % 133 == 125) 
				{
					Console.WriteLine($"{i} % 133 = 125");
					n++;
				}
				else if (i %134==111)
				{
					Console.WriteLine($"{i} % 134 = 111");
					n++;
                                }
			}
			Console.WriteLine($"Всего подходящих чисел {n}");
			Console.ReadKey();
		}
	}
}
