Console.Write("Ведите первое число:");
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
Console.Write("Ведите второе число:");
s = Console.ReadLine();
int b = s == null ? 0 : int.Parse(s);
if (a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else if (a < b)
{
    Console.WriteLine($"Число {a} меньше числа {b}");
}
else
{
    Console.WriteLine($"Число {a} равно числу {b}");
}