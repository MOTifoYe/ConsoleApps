using System;

namespace ConsoleApp1
{
    class Program
    {
        static int num = 0;
        static void Main(string[] args)
        {
            testFunc(num);
            testFunc(num);
        }
        public static void testFunc(int num)
        {
            Program.num++;
            Console.Write(Program.num);
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b[2]);
        }
    }
}
