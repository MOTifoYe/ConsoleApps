using System;

namespace MathTriangle
{
    class Program
    {

        const int cellWidth = 1;

        static void Main(string[] args)
        {
            Console.ReadKey();
            int row = Console.BufferWidth / 2;
            int[,] triangle = new int[row, row];

            FillTriangle(row, ref triangle);
            Magic(row, ref triangle);

        }
        static void FillTriangle(int row, ref int[,] triangle)
        {
            for (int i = 0; i < row; i++)
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;
            }

            for (int i = 2; i < row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    triangle[i, j] =
                        triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }
        }

        static void Magic(int row, ref int[,] triangle)
        {
            int col = cellWidth * row;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.SetCursorPosition(col, i + 1);
                    if (triangle[i, j] % 2 != 0) Console.WriteLine("*");
                    col += cellWidth * 2;
                }

                col = cellWidth * row - cellWidth * (i + 1);

                Console.WriteLine();
            }
        }
    }
}
