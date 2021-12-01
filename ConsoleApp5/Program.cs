using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0;
			int w = 500;
			while (q<20)
			{
				if (w % 13 == 0)
				{
					Console.WriteLine(w);
					q++;
				}
				else if (w % 17 == 0)
				{
					Console.WriteLine(w);
					q++;
				}
				w++;
			} 
        }
    }
}
