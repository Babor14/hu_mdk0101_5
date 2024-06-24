using mdk_0101__lab5_;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("год:");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("месяц:");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("день:");
int day = int.Parse(Console.ReadLine());
DateTime currentdate = new DateTime(year, month, day);
DayOfWeek whatday = currentdate.DayOfWeek;
Console.WriteLine($"дата{whatday}");
