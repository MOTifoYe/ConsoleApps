/*
 * Напишите программу для следующей задачи: 
 * Компьютер спрашивает названия двух планет, 
 * радиусы их орбиты (в миллионах километров) и 
 * скорости движения по орбите (в миллионах километров в сутки). 
 * 
 * Компьютер вычисляет продолжительность года на планетах и 
 * выдает результат в таком виде: 
 * Продолжительность года на планете Земля – 365 суток, 
 * а на планете Эоэлла – 12 суток.
 * 
 * T=2пr/v
    T-продолжительность года
    п-число пи (3,14)
    r-радиус орбиты
    v-скорость движения по орбите
    Никаких других величин нет.
 */

Console.Write("Название первой планеты: ");
string? planet1 = Console.ReadLine();
if (planet1 == null) planet1 = "string>null;";

Console.Write("Радиус орбиты первой планеты (в миллионах километров): ");
var result = double.TryParse(Console.ReadLine(), out double radiusPlanet1);
if (result == false) radiusPlanet1 = 20;

Console.Write("СкоростЬ движения по орбите (в миллионах километров в сутки): ");
result = double.TryParse(Console.ReadLine(), out double speedPlanet1);
if (result == false) speedPlanet1 = 10;

// // // // // // //

Console.Write("Название второй ппланеты: ");
string? planet2 = Console.ReadLine();
if (planet2 == null) planet2 = "string>null;";

Console.Write("Радиус орбиты второй планеты (в миллионах километров): ");
result = double.TryParse(Console.ReadLine(), out double radiusPlanet2);
if (result == false) radiusPlanet2 = 20;

Console.Write("СкоростЬ движения по орбите (в миллионах километров в сутки): ");
result = double.TryParse(Console.ReadLine(), out double speedPlanet2);
if (result == false) speedPlanet2 = 10;

// // // // // // //

double daysInYear1 = 2 * Math.PI * radiusPlanet1 / speedPlanet1;
double daysInYear2 = 2 * Math.PI * radiusPlanet2 / speedPlanet2;
Console.WriteLine();
Console.WriteLine($"Продолжительность года на планете {planet1} – {daysInYear1} суток, ");
Console.WriteLine($"а на планете {planet2} – {daysInYear2} суток.");