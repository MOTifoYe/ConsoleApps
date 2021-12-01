using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
			for (int i = 1000; i < 10000; i++)
			{
				if (i % 133 == 125 & i % 134 == 111)
				{
					Console.WriteLine(i);
				}
			}
		}
    }
}
