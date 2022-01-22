using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static int num = 0;
        static void testFunc()
        {
            Program.num++;
            Console.Write(Program.num);
            string a = "456";
            Console.WriteLine(a[2]);
        }
        static double Fibonacci(int n)
        {
            if (n == 1 || n == 2) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            testFunc();
            testFunc();

            Console.WriteLine(new Regex(@"[/*\-+]+$").Replace("23--**/*++69-*1*/-++--", ""));

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine($"f({i}) = {Fibonacci(i)}");
            }

            string a;
            while (true)
            {
                Console.Write("$ ");
                a = Console.ReadLine();

                if (a == "0") Environment.Exit(0);

                Console.WriteLine(a.Length);
                Console.WriteLine((a.Length == 0) ? "" : (a[^1].Equals('+') || a[^1].Equals('-') || a[^1].Equals('*') || a[^1].Equals('/') ? "" : "*"));
            }
        }
    }
}
