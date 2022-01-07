using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static int num = 0;
        static void Main(string[] args)
        {
            testFunc();
            testFunc();
            Console.WriteLine(new Regex(@"[/*\-+]+$").Replace("23--**/*++69-*1*/-++--", ""));
            string a;
            while (true)
            {
                Console.Write("$ ");
                a = Console.ReadLine();
                if (a == "0") { System.Environment.Exit(0); }
                Console.WriteLine(a.Length);
                Console.WriteLine( (a.Length == 0) ? "" : ( a[^1].Equals('+') || a[^1].Equals('-') || a[^1].Equals('*') || a[^1].Equals('/') ? "" : "*"  ) );

                Console.WriteLine(a[1].Equals('+') ? "" : "*");
            }
        }
        public static void testFunc()
        {
            Program.num++;
            Console.Write(Program.num);
            string a = "456";
            Console.WriteLine(a[2]);
        }
    }
}
