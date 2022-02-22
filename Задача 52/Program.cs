Console.Write("Какой сейчас год: ");
var result = int.TryParse(Console.ReadLine(), out int year);
if (result == false) year = DateTime.Now.Year;
if (year <= 0) year = DateTime.Now.Year;

Console.Write("Какой сейчас месяц: ");
result = int.TryParse(Console.ReadLine(), out int month);
if (result == false) month = DateTime.Now.Month;
if (month <= 0) month = DateTime.Now.Month;
if (month > 12) month = DateTime.Now.Month;

Console.Write("Какой сегодня день: ");
result = int.TryParse(Console.ReadLine(), out int day);
if (result == false) day = DateTime.Now.Day;
if (day <= 0) day = DateTime.Now.Day;
if (day > DateTime.DaysInMonth(year,month)) day = DateTime.Now.Day;

Console.WriteLine("\nИ так. Текущая дата: {0}-{1}-{2}", year, month, day);

day++;
if (day > DateTime.DaysInMonth(year,month))
{
    day = 1;
    month++;
    if (month > 12)
    {
        month = 1;
        year++;
    }
}

Console.WriteLine("\nСледующая дата: {0}-{1}-{2}", year, month, day);
