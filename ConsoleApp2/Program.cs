using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("введите число");
			int q = Convert.ToInt32(Console.ReadLine());

			if (q % 10 == 7)
			{
				Console.WriteLine("это 7 и оно не четное");
			}
			else if (q % 2 == 0)
			{
				Console.WriteLine("это четное число");

			}
			else
			{
				Console.WriteLine("это не четное число");
			}
		}
    }
}
