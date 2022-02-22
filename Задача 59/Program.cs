Console.WriteLine("Найти все двухзначные числа, которые делятся на n или содержат n");

int n = new Random().Next(1, 19);

Console.WriteLine("Число n = {0}", n);

for (int i = 10; i < 100; i++)
{
    int a = i % 10;
    int b = i / 10;

    if (i % n == 0 ) Console.WriteLine(i);
    if (a == n ) Console.WriteLine(i);
    if (b == n ) Console.WriteLine(i);
}
