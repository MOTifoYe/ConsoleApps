Console.WriteLine("Подсчитать сумму квадратов четных чисел от 1 до 100.");

int sum = 0;
for (int i = 0; i <= 100; i++)
{
    if (i % 2 == 0) sum += i * i;
}

Console.WriteLine(sum);