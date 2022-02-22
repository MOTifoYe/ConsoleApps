Console.WriteLine("Из двухзначных чисел вывести те, сумма цифр которых равна n");

int n = new Random().Next(1, 19);

Console.WriteLine("Число n = {0}", n);

for (int i = 10; i < 100; i++)
{
    int a = i % 10;
    int b = i / 10;

    if (a + b == n) Console.WriteLine(i);
}
