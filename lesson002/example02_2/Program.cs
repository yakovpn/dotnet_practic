Console.Write("Ведите первое число:");
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
Console.Write("Ведите второе число:");
s = Console.ReadLine();
int b = s == null ? 0 : int.Parse(s);
if (b % a == 0)
{
    Console.WriteLine($"Число {b} кратно числу {a}");
}
else
{
    Console.WriteLine($"Число {b} не кратно числу {a}, остаток от деления {b % a}");
}