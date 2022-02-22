Console.WriteLine("Подсчитать сумму всех чисел \n" +
    "от 1 до 100 при помощи цикла For.");

int sum = 0;
for (int i = 0; i <= 100; i++)
{
    sum += i;
}

Console.WriteLine(sum);