Console.Write("Введите номер дня недели:");
var s = Console.ReadLine();
int day = s == null ? 0 : int.Parse(s);
string stringDay = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames[day];
Console.WriteLine(stringDay);
