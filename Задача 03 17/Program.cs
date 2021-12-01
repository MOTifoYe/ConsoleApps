using System;

namespace Задача_03_17
{
    class Program
    {
        static void Main()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            const int f = 4;
            int t, M, r1, r2;
            bool y = false;
            Console.WriteLine("Настройка диапазона генерации чисел");
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Начало: ");
                        r1 = Convert.ToInt32(Console.ReadLine());
                        if (r1 == 0) { System.Environment.Exit(0); }
                        Console.Write("Конец: ");
                        r2 = Convert.ToInt32(Console.ReadLine());
                        if (r2 == 0) { System.Environment.Exit(0); }
                        Console.Write("порядок матрицы: ");
                        M = Convert.ToInt32(Console.ReadLine());
                        if (M == 0) { System.Environment.Exit(0); }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    break;
                }
                
                

                //генерация матрицы
                int[,] mat = new int[M, M];
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        mat[i, j] = random.Next(r1, r2);
                        Console.Write($"{mat[i, j],f}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("----------------------");
                /*
                // выборка главной диагонали
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (i == j)
                        {
                            Console.Write($"{mat[i,j] ,f}");
                        }
                    }
                }
                Console.WriteLine();

                // выборка значений выше главной диагонали
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (i < j)
                        {
                            Console.Write($"{mat[i, j],f}");
                        }
                    }
                }
                Console.WriteLine();

                // выборка значений ниже главной диагонали
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (i > j)
                        {
                            Console.Write($"{mat[i, j],f}");
                        }
                    }
                }
                Console.WriteLine();

                // выборка побоочной диагонали
                for (int i = 0; i < M; i++)
                {
                    for (int j = M-1; j >= 0; j--)
                    {
                        if (j == M-i-1)
                        {
                            Console.Write($"{mat[i, j] ,f}");
                        }
                    }
                }
                Console.WriteLine();

                // выборка значений выше побоочной диагонали
                for (int i = 0; i < M; i++)
                {
                    for (int j = M-1; j >= 0; j--)
                    {
                        if (j < M-i-1)
                        {
                            Console.Write($"{mat[i, j] ,f}");
                        }
                    }
                }
                Console.WriteLine();

                // выборка значений ниже побоочной диагонали
                for (int i = 0; i < M; i++)
                {
                    for (int j = M-1; j >= 0; j--)
                    {
                        if (j > M-i-1)
                        {
                            Console.Write($"{mat[i, j] ,f}");
                        }
                    }
                }
                Console.WriteLine("\n----------------------");
                */


                // теперь нужно выбрать число из тех, что выше главной диагонали
                // потом узнать есть ли одинаковые в диагонали и ниже ее
                for (int q = 0; q < M; q++)
                {
                    for (int w = 0; w < M; w++)
                    {
                        // выше главной
                        if (mat[q, w] != 0 && q < w)
                        {
                            // t = mat[q, w] это число, которое мы выбрали для проверки
                            // повторяется ли оно в диагонали и ниже ее
                            t = mat[q, w];
                            for (int i = 0; i < M; i++)
                            {
                                for (int j = 0; j < M; j++)
                                {
                                    // главная диагональ и ниже
                                    if (i >= j && mat[i, j] == t)
                                    {
                                        y = true;
                                        break;
                                    }
                                }
                            }
                            // если число повторяется меняем все числа
                            if (y)
                            {
                                for (int i = 0; i < M; i++)
                                {
                                    for (int j = 0; j < M; j++)
                                    {
                                        if (mat[i, j] == t)
                                        {
                                            mat[i, j] = 0;
                                        }
                                    }
                                }
                                y = false;
                                t = 0;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                // теперь нужно выбрать число из тех, что ниже главной диагонали
                // потом узнать есть ли одинаковые в диагонали и ниже ее
                for (int q = 0; q < M; q++)
                {
                    for (int w = 0; w < M; w++)
                    {
                        // ниже главной
                        if (mat[q, w] != 0 && q > w)
                        {
                            // t = mat[q, w] это число, которое мы выбрали для проверки
                            // повторяется ли оно в диагонали и выше ее
                            t = mat[q, w];
                            for (int i = 0; i < M; i++)
                            {
                                for (int j = 0; j < M; j++)
                                {
                                    // главная диагональ и выше
                                    if (i <= j && mat[i, j] == t)
                                    {
                                        y = true;
                                        break;
                                    }
                                }
                            }
                            // если число повторяется меняем все числа
                            if (y)
                            {
                                for (int i = 0; i < M; i++)
                                {
                                    for (int j = 0; j < M; j++)
                                    {
                                        if (mat[i, j] == t)
                                        {
                                            mat[i, j] = 0;
                                        }
                                    }
                                }
                                y = false;
                                t = 0;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                // теперь нужно выбрать число из тех, что выше побочной
                // потом узнать есть ли одинаковые в диагонали и ниже ее
                for (int q = 0; q < M; q++)
                {
                    for (int w = M - 1; w >= 0; w--)
                    {
                        // выше побочной
                        if (mat[q, w] != 0 && w < M - q - 1)
                        {
                            // t = mat[q, w] это число, которое мы выбрали для проверки
                            // повторяется ли оно в диагонали и ниже ее
                            t = mat[q, w];
                            for (int i = 0; i < M; i++)
                            {
                                for (int j = M - 1; j >= 0; j--)
                                {
                                    // побочная диагональ и ниже
                                    if (j >= M - i - 1 && mat[i, j] == t)
                                    {
                                        y = true;
                                        break;
                                    }
                                }
                            }
                            // если число повторяется меняем все числа
                            if (y)
                            {
                                for (int i = 0; i < M; i++)
                                {
                                    for (int j = 0; j < M; j++)
                                    {
                                        if (mat[i, j] == t)
                                        {
                                            mat[i, j] = 0;
                                        }
                                    }
                                }
                                y = false;
                                t = 0;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                // теперь нужно выбрать число из тех, что ниже побочной
                // потом узнать есть ли одинаковые в диагонали и выше ее
                for (int q = 0; q < M; q++)
                {
                    for (int w = M - 1; w >= 0; w--)
                    {
                        // ниже побочной
                        if (mat[q, w] != 0 && w > M - q - 1)
                        {
                            // t = mat[q, w] это число, которое мы выбрали для проверки
                            // повторяется ли оно в диагонали и выше ее
                            t = mat[q, w];
                            for (int i = 0; i < M; i++)
                            {
                                for (int j = M - 1; j >= 0; j--)
                                {
                                    // побочная диагональ и выше
                                    if (j <= M - i - 1 && mat[i, j] == t)
                                    {
                                        y = true;
                                        break;
                                    }
                                }
                            }
                            // если число повторяется меняем все числа
                            if (y)
                            {
                                for (int i = 0; i < M; i++)
                                {
                                    for (int j = 0; j < M; j++)
                                    {
                                        if (mat[i, j] == t)
                                        {
                                            mat[i, j] = 0;
                                        }
                                    }
                                }
                                y = false;
                                t = 0;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                // вывод матрицы
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write($"{mat[i, j],f}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
