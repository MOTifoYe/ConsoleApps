Console.WriteLine("Подсчитать сумму всех чисел, которые делятся на 3 без остатка в интервале от 1 до 100");

int sum = 0;
for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0) sum += i;
}

Console.WriteLine(sum);